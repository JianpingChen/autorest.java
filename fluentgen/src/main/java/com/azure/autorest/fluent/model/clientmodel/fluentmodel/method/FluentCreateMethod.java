/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 */

package com.azure.autorest.fluent.model.clientmodel.fluentmodel.method;

import com.azure.autorest.fluent.model.clientmodel.FluentCollectionMethod;
import com.azure.autorest.fluent.model.clientmodel.FluentManagerProperty;
import com.azure.autorest.fluent.model.clientmodel.FluentResourceCollection;
import com.azure.autorest.fluent.model.clientmodel.FluentResourceModel;
import com.azure.autorest.fluent.model.clientmodel.FluentStatic;
import com.azure.autorest.fluent.model.clientmodel.ModelNaming;
import com.azure.autorest.fluent.util.FluentUtils;
import com.azure.autorest.model.clientmodel.ClientMethodParameter;
import com.azure.autorest.model.clientmodel.ClientModelProperty;
import com.azure.autorest.model.clientmodel.ReturnValue;
import com.azure.autorest.model.javamodel.JavaJavadocComment;
import com.azure.autorest.template.prototype.MethodTemplate;

import java.util.List;
import java.util.Set;
import java.util.stream.Collectors;

public class FluentCreateMethod extends FluentMethod {

    private List<ClientMethodParameter> parameters;
    private FluentCollectionMethod collectionMethod;

    public FluentCreateMethod(FluentResourceModel model, FluentMethodType type,
                              List<ClientMethodParameter> parameters,
                              FluentResourceCollection collection, FluentCollectionMethod collectionMethod) {
        super(model, type);

        this.name = "create";
        this.description = "Executes the create request.";
        this.interfaceReturnValue = new ReturnValue("the created resource.", model.getInterfaceType());
        this.implementationReturnValue = interfaceReturnValue;

        this.parameters = parameters;
        this.collectionMethod = collectionMethod;

        collectionMethod.getInnerClientMethod().getParameters().stream()
                .filter(p -> !FluentUtils.isContextParameter(p))
                .filter(p -> !p.getClientType().toString().equals(model.getInnerModel().getName()))
                .forEach(p -> clientProperties.add(
                        new ClientModelProperty.Builder()
                                .name(p.getName())
                                .clientType(p.getClientType())
                                .build()));

        this.implementationMethodTemplate = MethodTemplate.builder()
                .methodSignature(this.getImplementationMethodSignature())
                .method(block -> {
                    // resource collection from manager
                    String collectionReferenceMethodName = FluentStatic.getFluentManager().getProperties().stream()
                            .filter(p -> p.getFluentType().getName().equals(collection.getInterfaceType().getName()))
                            .map(FluentManagerProperty::getMethodName)
                            .findFirst().get();

                    // method invocation
                    List<ClientMethodParameter> methodParameters = collectionMethod.getInnerClientMethod().getOnlyRequiredParameters() ? collectionMethod.getInnerClientMethod().getMethodRequiredParameters() : collectionMethod.getInnerClientMethod().getMethodParameters();
                    String argumentsLine = methodParameters.stream()
                            .map(p -> {
                                if (fluentResourceModel.getInnerModel().getName().equals(p.getClientType().toString())) {
                                    return ModelNaming.MODEL_PROPERTY_INNER;
                                } else {
                                    return p.getName();
                                }
                            })
                            .collect(Collectors.joining(", "));
                    String methodInvocation = String.format("%1$s(%2$s)", collectionMethod.getInnerClientMethod().getName(), argumentsLine);

                    block.line("this.%1$s = %2$s.%3$s().%4$s().%5$s;",
                            ModelNaming.MODEL_PROPERTY_INNER,
                            ModelNaming.MODEL_PROPERTY_MANAGER,
                            collectionReferenceMethodName,
                            ModelNaming.METHOD_INNER,
                            methodInvocation);
                    block.methodReturn("this");
                })
                .build();
    }

    @Override
    protected String getBaseMethodSignature() {
        String parameterText = parameters.stream()
                .map(p -> String.format("%1$s %2$s", p.getClientType().toString(), p.getName()))
                .collect(Collectors.joining(", "));
        return String.format("%1$s(%2$s)",
                this.name, parameterText);
    }

    @Override
    public void writeJavadoc(JavaJavadocComment commentBlock) {
        commentBlock.description(description);
        parameters.forEach(p -> commentBlock.param(p.getName(), p.getDescription()));
        commentBlock.methodReturns(interfaceReturnValue.getDescription());
    }

    @Override
    public void addImportsTo(Set<String> imports, boolean includeImplementationImports) {
        interfaceReturnValue.addImportsTo(imports, false);
        parameters.forEach(p -> p.addImportsTo(imports, false));
        if (includeImplementationImports) {
            collectionMethod.addImportsTo(imports, false);
        }
    }
}