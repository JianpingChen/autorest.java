package com.azure.autorest;

import com.azure.autorest.extension.base.jsonrpc.Connection;
import com.azure.autorest.extension.base.model.codemodel.CodeModel;
import com.azure.autorest.extension.base.plugin.JavaSettings;
import com.azure.autorest.extension.base.plugin.JavaSettings.SyncMethodsGeneration;
import com.azure.autorest.extension.base.plugin.NewPlugin;
import com.azure.autorest.mapper.Mappers;
import com.azure.autorest.model.clientmodel.Client;
import com.azure.autorest.model.clientmodel.ClientException;
import com.azure.autorest.model.clientmodel.ClientModel;
import com.azure.autorest.model.clientmodel.ClientResponse;
import com.azure.autorest.model.clientmodel.EnumType;
import com.azure.autorest.model.clientmodel.MethodGroupClient;
import com.azure.autorest.model.clientmodel.PackageInfo;
import com.azure.autorest.model.clientmodel.XmlSequenceWrapper;
import com.azure.autorest.model.javamodel.JavaFile;
import com.azure.autorest.model.javamodel.JavaPackage;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.yaml.snakeyaml.Yaml;
import org.yaml.snakeyaml.introspector.Property;
import org.yaml.snakeyaml.nodes.NodeTuple;
import org.yaml.snakeyaml.nodes.Tag;
import org.yaml.snakeyaml.representer.Representer;

import java.util.List;
import java.util.stream.Collectors;

public class Javagen extends NewPlugin {
    private static final Logger LOGGER = LoggerFactory.getLogger(Javagen.class);
    public Javagen(Connection connection, String plugin, String sessionId) {
        super(connection, plugin, sessionId);
    }

    @Override
    public boolean processInternal() {
        List<String> allFiles = listInputs();
        List<String> files = allFiles.stream().filter(s -> s.contains("no-tags")).collect(Collectors.toList());
        if (files.size() != 1) {
            throw new RuntimeException(String.format("Generator received incorrect number of inputs: %s : %s}", files.size(), String.join(", ", files)));
        }

        try {
            // Step 1: Parse input yaml as CodeModel
            String file = readFile(files.get(0));
            Representer representer = new Representer() {
                @Override
                protected NodeTuple representJavaBeanProperty(Object javaBean, Property property, Object propertyValue,
                    Tag customTag) {
                    // if value of property is null, ignore it.
                    if (propertyValue == null) {
                        return null;
                    }
                    else {
                        return super.representJavaBeanProperty(javaBean, property, propertyValue, customTag);
                    }
                }
            };

            Yaml newYaml  = new Yaml(representer);
            CodeModel codeModel = newYaml.loadAs(file, CodeModel.class);

            // Step 2: Map
            Client client = Mappers.getClientMapper().map(codeModel);

            // Step 3: Write to templates
            JavaPackage javaPackage = new JavaPackage();
            // Service client
            javaPackage
                .addServiceClient(client.getServiceClient().getPackage(), client.getServiceClient().getClassName(),
                    client.getServiceClient());

            if (JavaSettings.getInstance().shouldGenerateSyncAsyncClients()) {
                String asyncClassName =
                    client.getServiceClient().getClientBaseName().endsWith("Client") ? client.getServiceClient()
                        .getClientBaseName().replace("Client", "AsyncClient")
                        : client.getServiceClient().getClientBaseName() + "AsyncClient";

                javaPackage.addAsyncServiceClient(JavaSettings.getInstance().getPackage(),
                    asyncClassName, client.getServiceClient());

                // generate sync client only if the sync method generation param is set to ALL.
                if (SyncMethodsGeneration.ALL.equals(JavaSettings.getInstance().getSyncMethods())) {
                    String syncClassName =
                        client.getServiceClient().getClientBaseName().endsWith("Client") ? client.getServiceClient()
                            .getClientBaseName() : client.getServiceClient().getClientBaseName() + "Client";
                    javaPackage.addSyncServiceClient(JavaSettings.getInstance().getPackage(),
                        syncClassName, client.getServiceClient());
                }
            }

            if (JavaSettings.getInstance().shouldGenerateClientInterfaces()) {
                javaPackage
                    .addServiceClientInterface(client.getServiceClient().getInterfaceName(), client.getServiceClient());
            }

            // Service client builder
            javaPackage.addServiceClientBuilder(client.getServiceClient().getInterfaceName() + "Builder",
                    client.getServiceClient());

            // Method group
            for (MethodGroupClient methodGroupClient : client.getServiceClient().getMethodGroupClients()) {
                javaPackage.addMethodGroup(methodGroupClient.getPackage(), methodGroupClient.getClassName(),
                    methodGroupClient);
                if (JavaSettings.getInstance().shouldGenerateClientInterfaces()) {
                    javaPackage.addMethodGroupInterface(methodGroupClient.getInterfaceName(), methodGroupClient);
                }
            }

            // Response
            for (ClientResponse response : client.getResponseModels()) {
                javaPackage.addClientResponse(response.getPackage(), response.getName(), response);
            }

            // Client model
            for (ClientModel model : client.getModels()) {
                javaPackage.addModel(model.getPackage(), model.getName(), model);
            }

            // Enum
            for (EnumType enumType : client.getEnums()) {
                javaPackage.addEnum(enumType.getPackage(), enumType.getName(), enumType);
            }

            // Exception
            for (ClientException exception : client.getExceptions()) {
                javaPackage.addException(exception.getPackage(), exception.getName(), exception);
            }

            // XML sequence wrapper
            for (XmlSequenceWrapper xmlSequenceWrapper : client.getXmlSequenceWrappers()) {
                javaPackage.addXmlSequenceWrapper(xmlSequenceWrapper.getPackage(),
                    xmlSequenceWrapper.getWrapperClassName(), xmlSequenceWrapper);
            }

            // Package-info
            for (PackageInfo packageInfo : client.getPackageInfos()) {
                javaPackage.addPackageInfo(packageInfo.getPackage(), "package-info", packageInfo);
            }

            // TODO: POM, Manager

            //Step 4: Print to files
            for (JavaFile javaFile : javaPackage.getJavaFiles()) {
                writeFile(javaFile.getFilePath(), javaFile.getContents().toString(), null);
            }
        } catch (Exception ex) {
            LOGGER.error("Failed to generate code " + ex.getMessage(), ex);
            connection.sendError(1, 500, "Failed to generate code: " + ex.getMessage());
            return false;
        }
        return true;
    }
}