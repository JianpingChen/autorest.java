﻿using AutoRest.Core;
using AutoRest.Core.Model;
using AutoRest.Core.Utilities;
using AutoRest.Core.Utilities.Collections;
using AutoRest.Extensions.Azure;
using AutoRest.Java.Azure;
using AutoRest.Java.Azure.Fluent.Model;
using AutoRest.Java.Azure.Model;
using AutoRest.Java.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AutoRest.Java.DanModel
{
    public static class DanCodeGenerator
    {
        public static IEnumerable<JavaFile> GetXmlWrapperJavaFiles(CodeModelJv codeModel, Settings settings)
        {
            IEnumerable<JavaFile> result;
            if (!codeModel.ShouldGenerateXmlSerializationCached)
            {
                result = Enumerable.Empty<JavaFile>();
            }
            else
            {
                Dictionary<SequenceTypeJv, JavaFile> javaFileMap = new Dictionary<SequenceTypeJv, JavaFile>();

                // Every sequence type used as a parameter to a service method.
                foreach (MethodGroup methodGroup in codeModel.Operations)
                {
                    foreach (Method method in methodGroup.Methods)
                    {
                        foreach (Parameter parameter in method.Parameters)
                        {
                            IModelType parameterType = parameter.ModelType;
                            if (parameterType is SequenceTypeJv sequenceType && !javaFileMap.Keys.Contains(sequenceType, ModelNameComparer.Instance))
                            {
                                string sequenceTypeName = sequenceType.Name;
                                string xmlName = sequenceType.XmlName;
                                string xmlNameCamelCase = xmlName.ToCamelCase();
                                string className = $"{xmlName.ToPascalCase()}Wrapper";

                                JavaFile javaFile = GenerateJavaFileWithHeaderAndPackage(codeModel, codeModel.ImplPackage, settings, className);
                                javaFile.Import(sequenceType.Imports.Concat(new string[]
                                {
                                    "com.fasterxml.jackson.annotation.JsonCreator",
                                    "com.fasterxml.jackson.annotation.JsonProperty",
                                    "com.fasterxml.jackson.dataformat.xml.annotation.JacksonXmlProperty",
                                    "com.fasterxml.jackson.dataformat.xml.annotation.JacksonXmlRootElement"
                                }));
                                javaFile.Annotation($"JacksonXmlRootElement(localName = \"{xmlName}\")");
                                javaFile.PublicClass(className, classBlock =>
                                {
                                    classBlock.Line();
                                    classBlock.Annotation($"JacksonXmlProperty(localName = \"{sequenceType.ElementXmlName}\")");
                                    classBlock.Line($"private final {sequenceTypeName} {xmlNameCamelCase};");
                                    classBlock.Line();
                                    classBlock.Annotation("JsonCreator");
                                    classBlock.Block($"public {className}(@JsonProperty(\"{xmlNameCamelCase}\") {sequenceTypeName} {xmlNameCamelCase})", constructor =>
                                    {
                                        constructor.Line($"this.{xmlNameCamelCase} = {xmlNameCamelCase};");
                                    });
                                    classBlock.Line();
                                    classBlock.MultipleLineComment(comment =>
                                    {
                                        comment.Line($"Get the {xmlName} value.");
                                        comment.Line();
                                        comment.Return($"the {xmlName} value");
                                    });
                                    classBlock.Block($"public {sequenceTypeName} {xmlNameCamelCase}()", function =>
                                    {
                                        function.Return(xmlNameCamelCase);
                                    });
                                });

                                javaFileMap.Add(sequenceType, javaFile);
                            }
                        }
                    }
                }
                result = javaFileMap.Values;
            }
            return result;
        }

        public static JavaFile GetAzureServiceClientJavaFile(CodeModelJva codeModel, Settings settings)
        {
            int maximumCommentWidth = GetMaximumCommentWidth(settings);

            string className = $"{codeModel.Name.ToPascalCase()}Impl";

            JavaFile javaFile = GenerateJavaFileWithHeaderAndPackage(codeModel, codeModel.ImplPackage, settings, className);
            
            javaFile.Import(codeModel.ImplImports);

            javaFile.MultipleLineComment(comment =>
            {
                comment.Line($"Initializes a new instance of the {className} class.");
            });
            javaFile.Block($"public class {className}{codeModel.ParentDeclaration}", classBlock =>
            {
                string serviceClientType = codeModel.ServiceClientServiceType;
                IEnumerable<MethodJv> rootMethods = codeModel.RootMethods;
                bool hasRootMethods = rootMethods.Any();

                if (hasRootMethods)
                {
                    classBlock.SingleLineComment("The RestProxy service to perform REST calls.");
                    classBlock.Line($"private {serviceClientType} service;");
                }
                classBlock.Line();

                AddMemberVariablesWithGettersAndSettings(classBlock, codeModel.PropertiesEx, className);

                foreach (MethodGroupJv operation in codeModel.AllOperations)
                {
                    classBlock.Line();
                    classBlock.MultipleLineComment(comment =>
                    {
                        comment.Line($"The {operation.MethodGroupDeclarationType} object to access its operations.");
                    });
                    classBlock.Line($"private {operation.MethodGroupDeclarationType} {operation.Name};");
                    classBlock.Line();
                    classBlock.MultipleLineComment(comment =>
                    {
                        comment.Line($"Gets the {operation.MethodGroupDeclarationType} object to access its operations.");
                        comment.Return($"the {operation.MethodGroupDeclarationType} object.");
                    });
                    classBlock.Block($"public {operation.MethodGroupDeclarationType} {operation.Name}()", function =>
                    {
                        function.Return($"this.{operation.Name}");
                    });
                }
                classBlock.Line();

                Action<JavaMultipleLineComment> addConstructorDescription = (JavaMultipleLineComment comment) =>
                {
                    comment.Line($"Initializes an instance of {codeModel.Name} client.");
                };
                if (settings.AddCredentials)
                {
                    string constructorDescription = $"Initializes an instance of {codeModel.Name} client.";
                    classBlock.MultipleLineComment(comment =>
                    {
                        addConstructorDescription(comment);
                        comment.Line();
                        comment.Param("credentials", "the management credentials for Azure");
                    });
                    classBlock.Block($"public {className}(ServiceClientCredentials credentials)", constructor =>
                    {
                        constructor.Line($"this(\"{codeModel.BaseUrl}\", credentials);");
                    });
                    classBlock.Line();
                    classBlock.MultipleLineComment(comment =>
                    {
                        addConstructorDescription(comment);
                        comment.Line();
                        comment.Param("baseUrl", "the base URL of the host");
                        comment.Param("credentials", "the management credentials for Azure");
                    });

                    string constructorVisibility = codeModel.IsCustomBaseUri ? "private" : "public";
                    classBlock.Block($"{constructorVisibility} {className}(String baseUrl, ServiceClientCredentials credentials)", constructor =>
                    {
                        constructor.Line("super(baseUrl, credentials);");
                        constructor.Line("initialize();");
                    });
                    classBlock.Line();

                    classBlock.MultipleLineComment(comment =>
                    {
                        addConstructorDescription(comment);
                        comment.Line();
                        comment.Param("restClient", "the REST client to connect to Azure.");
                    });
                    classBlock.Block($"public {className}(RestClient restClient)", constructor =>
                    {
                        constructor.Line("super(restClient);");
                        constructor.Line("initialize();");
                    });
                    classBlock.Line();
                }
                else
                {
                    classBlock.MultipleLineComment(comment =>
                    {
                        addConstructorDescription(comment);
                    });
                    classBlock.Block($"public {className}()", constructor =>
                    {
                        constructor.Line($"this(\"{codeModel.BaseUrl}\");");
                    });
                    classBlock.Line();
                    classBlock.MultipleLineComment(comment =>
                    {
                        addConstructorDescription(comment);
                        comment.Line();
                        comment.Param("baseUrl", "the base URL of the host");
                    });
                    classBlock.Block($"{(codeModel.IsCustomBaseUri ? "private" : "public")} {className}(String baseUrl)", constructor =>
                    {
                        constructor.Line("this(baseUrl, null);");
                    });
                    classBlock.Line();
                    classBlock.MultipleLineComment(comment =>
                    {
                        addConstructorDescription(comment);
                        comment.Line();
                        comment.Param("restClient", "the REST client to connect to Azure");
                    });
                    classBlock.Block($"public {className}(RestClient restClient)", constructor =>
                    {
                        constructor.Line("super(restClient);");
                        constructor.Line($"restClient.baseUrl(\"{codeModel.BaseUrl}\");");
                        constructor.Line("initialize();");
                    });
                    classBlock.Line();
                }

                classBlock.Block("protected void initialize()", function =>
                {
                    foreach (Property property in codeModel.PropertiesEx.Where(p => p.DefaultValue != null))
                    {
                        function.Line($"this.{property.Name} = {property.DefaultValue};");
                    }

                    foreach (MethodGroupJva operation in codeModel.AllOperations)
                    {
                        function.Line($"this.{operation.Name} = new {operation.MethodGroupImplType}(this);");
                    }

                    string defaultHeaders = codeModel.SetDefaultHeaders;
                    if (!string.IsNullOrWhiteSpace(defaultHeaders))
                    {
                        function.Line(codeModel.SetDefaultHeaders);
                    }

                    if (hasRootMethods)
                    {
                        function.Line("initializeService();");
                    }
                });
                classBlock.Line();
                classBlock.MultipleLineComment(comment =>
                {
                    comment.Line("Gets the User-Agent header for the client.");
                    comment.Line();
                    comment.Return("the user agent string.");
                });
                classBlock.Annotation("Override");
                classBlock.Block("public String userAgent()", function =>
                {
                    if (codeModel.ApiVersion == null)
                    {
                        function.Return($"String.format(\"%s (%s)\", super.userAgent(), \"{codeModel.Name}\")");
                    }
                    else
                    {
                        function.Return($"String.format(\"%s (%s, %s)\", super.userAgent(), \"{codeModel.Name}\", \"{codeModel.ApiVersion}\")");
                    }
                });

                if (hasRootMethods)
                {
                    classBlock.Line();
                    classBlock.Block("private void initializeService()", function =>
                    {
                        function.Line($"service = AzureProxy.create({serviceClientType}.class, restClient().baseURL(), httpClient(), serializerAdapter());");
                    });

                    classBlock.Line();

                    IMethodGroupJva methodGroup = codeModel;

                    classBlock.WordWrappedMultipleLineComment(maximumCommentWidth, comment =>
                    {
                        comment.Line($"The interface defining all the services for {methodGroup.Name} to be used by RestProxy to perform REST calls.");
                    });
                    classBlock.Annotation($"Host(\"{methodGroup.CodeModel.BaseUrl}\")");
                    classBlock.Block($"interface {methodGroup.ServiceType}", interfaceBlock =>
                    {
                        foreach (MethodJva method in methodGroup.Methods)
                        {
                            interfaceBlock.Annotation($"Headers({{ \"x-ms-logging-context: {methodGroup.LoggingContext} {method.Name}\" }})");
                            if (method.IsPagingNextOperation)
                            {
                                interfaceBlock.Annotation("GET(\"{{nextUrl}}\")");
                            }
                            else
                            {
                                interfaceBlock.Annotation($"{method.HttpMethod.ToString().ToUpper()}(\"{method.Url.TrimStart('/')}\")");
                            }
                            interfaceBlock.Line(method.ExpectedResponsesAnnotation);
                            if (method.DefaultResponse.Body != null)
                            {
                                interfaceBlock.Annotation($"UnexpectedResponseExceptionType({method.OperationExceptionTypeString}.class)");
                            }

                            if (method.IsLongRunningOperation)
                            {
                                interfaceBlock.Line($"Observable<OperationStatus<{method.ReturnTypeJva.ServiceResponseGenericParameterString}>> {method.Name}({method.MethodParameterApiDeclaration});");
                            }
                            else
                            {
                                interfaceBlock.Line($"Single<{method.RestResponseConcreteTypeName}> {method.Name}({method.MethodParameterApiDeclaration});");
                            }

                            interfaceBlock.Line();
                        }
                    });

                    classBlock.Line();
                }

                foreach (MethodJva method in rootMethods)
                {
                    IEnumerable<ParameterJv> nonConstantLocalParameters = method.LocalParameters.Where(p => !p.IsConstant);
                    IEnumerable<ParameterJv> nonConstantOptionalLocalParameters = nonConstantLocalParameters.Where(p => !p.IsRequired);
                    IEnumerable<ParameterJv> nonConstantRequiredLocalParameters = nonConstantLocalParameters.Where(p => p.IsRequired);

                    if (method.IsPagingOperation || method.IsPagingNextOperation)
                    {
                        if (nonConstantOptionalLocalParameters.Any())
                        {
                            // -----------------------------------------------
                            // All pages. Synchronous with required parameters
                            // -----------------------------------------------
                            classBlock.MultipleLineComment(comment =>
                            {
                                AddMethodSummaryAndDescription(comment, method);
                                AddParameters(comment, nonConstantRequiredLocalParameters);
                                ThrowsIllegalArgumentException(comment);
                                ThrowsOperationException(comment, method.OperationExceptionTypeString);
                                ThrowsRuntimeException(comment);
                                if (method.ReturnType.Body != null)
                                {
                                    comment.Return($"the {method.ReturnTypeResponseName.EscapeXmlComment()} object if successful.");
                                }
                            });
                            classBlock.Block($"public {method.ReturnTypeResponseName} {method.Name}({method.MethodRequiredParameterDeclaration})", function =>
                            {
                                function.Line($"{method.ReturnTypeJva.ServiceResponseGenericParameterString} response = {method.Name}SinglePageAsync({method.MethodRequiredParameterInvocation}).toBlocking().value();");
                                function.Block($"return new {method.ReturnTypeJva.GenericBodyClientTypeString}(response)", anonymousClass =>
                                {
                                    anonymousClass.Annotation("Override");
                                    anonymousClass.Block($"public {method.ReturnTypeJva.ServiceResponseGenericParameterString} nextPage(String {method.PagingNextPageLinkParameterName})", subFunction =>
                                    {
                                        subFunction.Line(method.PagingGroupedParameterTransformation(filterRequired: true));
                                        subFunction.Return($"{method.GetPagingNextMethodInvocation(async: true)}({method.NextMethodParameterInvocation(filterRequired: true)}).toBlocking().value()");
                                    });
                                });
                            });
                            classBlock.Line();

                            // -----------------------------------------------
                            // All pages. Observable with required parameters.
                            // -----------------------------------------------
                            classBlock.MultipleLineComment(comment =>
                            {
                                AddMethodSummaryAndDescription(comment, method);
                                AddParameters(comment, nonConstantRequiredLocalParameters);
                                ThrowsIllegalArgumentException(comment);
                                if (method.ReturnType.Body != null)
                                {
                                    comment.Return($"the observable to the {method.ReturnTypeResponseName.EscapeXmlComment()} object");
                                }
                                else
                                {
                                    comment.Return($"the {{@link Observable<{method.ReturnTypeJva.ServiceResponseGenericParameterString}>}} object if successful.");
                                }
                            });
                            classBlock.Block($"public Observable<{method.ReturnTypeJva.ServiceResponseGenericParameterString}> {method.Name}Async({method.MethodRequiredParameterDeclaration})", function =>
                            {
                                function.Line($"return {method.Name}SinglePageAsync({method.MethodRequiredParameterInvocation})");
                                function.Indent(() =>
                                {
                                    function.Line(".toObservable()");
                                    function.Block($".concatMap(new Func1<{method.ReturnTypeJva.ServiceResponseGenericParameterString}, Observable<{method.ReturnTypeJva.ServiceResponseGenericParameterString}>>()", anonymousClass =>
                                    {
                                        anonymousClass.Annotation("Override");
                                        anonymousClass.Block($"public Observable<{method.ReturnTypeJva.ServiceResponseGenericParameterString}> call({method.ReturnTypeJva.ServiceResponseGenericParameterString} page)", subFunction =>
                                        {
                                            subFunction.Line($"String {method.PagingNextPageLinkParameterName} = page.nextPageLink();");
                                            subFunction.If($"{method.PagingNextPageLinkParameterName} == null", ifBlock =>
                                            {
                                                ifBlock.Return("Observable.just(page)");
                                            });
                                            subFunction.Line(method.PagingGroupedParameterTransformation(filterRequired: true));
                                            subFunction.Return($"return Observable.just(page).concatWith({method.GetPagingNextMethodInvocation(async: true, singlePage: false)}({method.NextMethodParameterInvocation(filterRequired: true)});");
                                        });
                                    });
                                });
                            });
                            classBlock.Line();

                            // -------------------------------------------------
                            // Single page. Observable with required parameters.
                            // -------------------------------------------------
                            classBlock.MultipleLineComment(comment =>
                            {
                                AddMethodSummaryAndDescription(comment, method);
                                AddParameters(comment, nonConstantRequiredLocalParameters);
                                ThrowsIllegalArgumentException(comment);
                                if (method.ReturnType.Body != null)
                                {
                                    comment.Return($"the {method.ReturnTypeResponseName} object if successful.");
                                }
                                else
                                {
                                    comment.Return($"the {{@link Single<{method.ReturnTypeJva.ServiceResponseGenericParameterString}>}} object if successful.");
                                }
                            });
                            classBlock.Block($"public Single<{method.ReturnTypeJva.ServiceResponseGenericParameterString}> {method.Name}SinglePageAsync({method.MethodRequiredParameterDeclaration})", function =>
                            {
                                foreach (ParameterJv param in method.RequiredNullableParameters)
                                {
                                    function.If($"{param.Name} == null)", ifBlock =>
                                    {
                                        ifBlock.Line($"throw new IllegalArgumentException(\"Parameter {param.Name} is required and cannot be null.\");");
                                    });
                                }

                                foreach (ParameterJv param in method.ParametersToValidate.Where(p => p.IsRequired))
                                {
                                    function.Line($"Validator.validate({param.Name});");
                                }

                                foreach (ParameterJv parameter in method.LocalParameters)
                                {
                                    if (!parameter.IsRequired)
                                    {
                                        function.Line($"final {parameter.ClientType.Name} {parameter.Name} = {parameter.ClientType.GetDefaultValue(method) ?? "null"});");
                                    }
                                    if (parameter.IsConstant)
                                    {
                                        function.Line($"final {parameter.ClientType.ParameterVariant.Name} {parameter.Name} = {parameter.DefaultValue ?? "null"});");
                                    }
                                }

                                function.Line(method.BuildInputMappings(true));
                                function.Line(method.ParameterConversion);
                                if (method.IsPagingNextOperation)
                                {
                                    function.Line($"String nextUrl = {method.NextUrlConstruction};");
                                }
                                function.Block($"return service.{method.Name}({method.MethodParameterApiInvocation}).map(new Func1<{method.RestResponseConcreteTypeName}, {method.ReturnTypeJva.ServiceResponseGenericParameterString}>()", anonymousClass =>
                                {
                                    anonymousClass.Annotation("Override");
                                    anonymousClass.Block($"public {method.ReturnTypeJva.ServiceResponseGenericParameterString} call({method.RestResponseConcreteTypeName} response)", subFunction =>
                                    {
                                        subFunction.Return("response.body()");
                                    });
                                });
                            });

                            classBlock.Line();
                        }

                        // -------------------------------------------
                        // All pages. Synchronous with all parameters.
                        // -------------------------------------------
                        classBlock.MultipleLineComment(comment =>
                        {
                            AddMethodSummaryAndDescription(comment, method);
                            AddParameters(comment, nonConstantLocalParameters);
                            ThrowsIllegalArgumentException(comment);
                            ThrowsOperationException(comment, method.OperationExceptionTypeString);
                            ThrowsRuntimeException(comment);
                            if (method.ReturnType.Body != null)
                            {
                                comment.Return($"the {method.ReturnTypeResponseName.EscapeXmlComment()} object if successful.");
                            }
                        });
                        classBlock.Block($"public {method.ReturnTypeResponseName} {method.Name}({method.MethodParameterDeclaration})", function =>
                        {
                            function.Line($"{method.ReturnTypeJva.ServiceResponseGenericParameterString} response = {method.Name}SinglePageAsync({method.MethodParameterInvocation}).toBlocking().value();");
                            function.Block($"return new {method.ReturnTypeJva.GenericBodyClientTypeString}(response)", anonymousClass =>
                            {
                                anonymousClass.Annotation("Override");
                                anonymousClass.Block($"public {method.ReturnTypeJva.ServiceResponseGenericParameterString} nextPage(String {method.PagingNextPageLinkParameterName})", subFunction =>
                                {
                                    subFunction.Line(method.PagingGroupedParameterTransformation());
                                    subFunction.Return($"{method.GetPagingNextMethodInvocation(async: true)}({method.NextMethodParameterInvocation()}).toBlocking().value()");
                                });
                            });
                        });

                        classBlock.Line();

                        // ------------------------------------------
                        // All pages. Observable with all parameters.
                        // ------------------------------------------
                        classBlock.MultipleLineComment(comment =>
                        {
                            AddMethodSummaryAndDescription(comment, method);
                            AddParameters(comment, nonConstantLocalParameters);
                            ThrowsIllegalArgumentException(comment);
                            if (method.ReturnType.Body != null)
                            {
                                comment.Return($"the observable to the {method.ReturnTypeResponseName} object");
                            }
                            else
                            {
                                comment.Return($"the {{@link Single<{method.ReturnTypeJva.ServiceResponseGenericParameterString}>}} object if successful.");
                            }
                        });
                        classBlock.Block($"public Observable<{method.ReturnTypeJva.ServiceResponseGenericParameterString}> {method.Name}Async({method.MethodParameterDeclaration})", function =>
                        {
                            function.Line($"return {method.Name}SinglePageAsync({method.MethodParameterInvocation})");
                            function.Indent(() =>
                            {
                                function.Line(".toObservable()");
                                function.Block($".concatMap(new Func1<{method.ReturnTypeJva.ServiceResponseGenericParameterString}, Observable<{method.ReturnTypeJva.ServiceResponseGenericParameterString}>>()", anonymousClass =>
                                {
                                    anonymousClass.Annotation("Override");
                                    anonymousClass.Block($"public Observable<{method.ReturnTypeJva.ServiceResponseGenericParameterString}> call({method.ReturnTypeJva.ServiceResponseGenericParameterString} page)", subFunction =>
                                    {
                                        subFunction.Line($"String {method.PagingNextPageLinkParameterName} = page.nextPageLink();");
                                        subFunction.If($"{method.PagingNextPageLinkParameterName} == null", ifBlock =>
                                        {
                                            ifBlock.Return("Observable.just(page)");
                                        });
                                        subFunction.Line(method.PagingGroupedParameterTransformation());
                                        subFunction.Return($"Observable.just(page).concatWith({method.GetPagingNextMethodInvocation(async: true, singlePage: false)}({method.NextMethodParameterInvocation()});");
                                    });
                                });
                            });
                        });
                        classBlock.Line();

                        // --------------------------------------------
                        // Single page. Observable with all parameters.
                        // --------------------------------------------
                        classBlock.MultipleLineComment(comment =>
                        {
                            AddMethodSummaryAndDescription(comment, method);
                            AddParameters(comment, nonConstantLocalParameters);
                            ThrowsIllegalArgumentException(comment);
                            if (method.ReturnType.Body != null)
                            {
                                comment.Return($"the {method.ReturnTypeResponseName} object if successful.");
                            }
                            else
                            {
                                comment.Return($"the {{@link Single<{method.ReturnTypeJva.ServiceResponseGenericParameterString}>}} object if successful.");
                            }
                        });
                        classBlock.Block($"public Single<{method.ReturnTypeJva.ServiceResponseGenericParameterString}> {method.Name}SinglePageAsync({method.MethodParameterDeclaration})", function =>
                        {
                            foreach (ParameterJv param in method.RequiredNullableParameters)
                            {
                                function.If($"{param.Name} == null", ifBlock =>
                                {
                                    function.Line($"throw new IllegalArgumentException(\"Parameter {param.Name} is required and cannot be null.\");");
                                });
                            }

                            foreach (ParameterJv param in method.ParametersToValidate)
                            {
                                function.Line($"Validator.validate({param.Name});");
                            }

                            foreach (ParameterJv parameter in method.LocalParameters)
                            {
                                if (parameter.IsConstant)
                                {
                                    function.Line($"final {parameter.ModelType.Name} {parameter.Name} = {parameter.DefaultValue ?? "null"};");
                                }
                            }

                            function.Line(method.BuildInputMappings());
                            function.Line(method.ParameterConversion);
                            if (method.IsPagingNextOperation)
                            {
                                function.Line($"String nextUrl = {method.NextUrlConstruction};");
                            }
                            function.Block($"return service.{method.Name}({method.MethodParameterApiInvocation}).map(new Func1<{method.RestResponseConcreteTypeName}, {method.ReturnTypeJva.ServiceResponseGenericParameterString}>()", anonymousClass =>
                            {
                                anonymousClass.Annotation("Override");
                                anonymousClass.Block($"public {method.ReturnTypeJva.ServiceResponseGenericParameterString} call({method.RestResponseConcreteTypeName} response)", subFunction =>
                                {
                                    subFunction.Return("response.body()");
                                });
                            });
                        });
                        classBlock.Line();
                    }
                    else
                    {
                        if (!method.IsLongRunningOperation)
                        {
                            GenerateRootMethodFunctions(classBlock, method);
                        }
                        else
                        {
                            if (nonConstantOptionalLocalParameters.Any())
                            {
                                // -----------------------------------------
                                // Synchronous with only required parameters
                                // -----------------------------------------
                                classBlock.MultipleLineComment(comment =>
                                {
                                    AddMethodSummaryAndDescription(comment, method);
                                    AddParameters(comment, nonConstantRequiredLocalParameters);
                                    ThrowsIllegalArgumentException(comment);
                                    ThrowsOperationException(comment, method.OperationExceptionTypeString);
                                    ThrowsRuntimeException(comment);
                                    if (method.ReturnType.Body != null)
                                    {
                                        comment.Return($"the {method.ReturnTypeResponseName.EscapeXmlComment()} object if successful.");
                                    }
                                });
                                classBlock.Block($"public {method.ReturnTypeResponseName} {method.Name}({method.MethodRequiredParameterDeclaration})", function =>
                                {
                                    if (method.ReturnTypeJva.BodyClientType.ResponseVariant.Name == "void")
                                    {
                                        function.Line($"{method.Name}Async({method.MethodRequiredParameterInvocation}).toBlocking().last().result();");
                                    }
                                    else
                                    {
                                        function.Return($"{method.Name}Async({method.MethodRequiredParameterInvocation}).toBlocking().last().result()");
                                    }
                                });

                                // --------------------------------------
                                // Callback with only required parameters
                                // --------------------------------------
                                classBlock.MultipleLineComment(comment =>
                                {
                                    AddMethodSummaryAndDescription(comment, method);
                                    AddParameters(comment, nonConstantRequiredLocalParameters);
                                    ParamServiceCallback(comment);
                                    ThrowsIllegalArgumentException(comment);
                                    comment.Return("the {@link ServiceFuture} object");
                                });
                                classBlock.Block($"public ServiceFuture<{method.ReturnTypeJva.ServiceFutureGenericParameterString}> {method.Name}Async({method.MethodRequiredParameterDeclarationWithCallback})", function =>
                                {
                                    function.Return($"ServiceFutureUtil.fromLRO({method.Name}Async({method.MethodRequiredParameterInvocation}, serviceCallback)");
                                });

                                // ----------------------------------------
                                // Observable with only required parameters
                                // ----------------------------------------
                                classBlock.MultipleLineComment(comment =>
                                {
                                    AddMethodSummaryAndDescription(comment, method);
                                    AddParameters(comment, nonConstantRequiredLocalParameters);
                                    ThrowsIllegalArgumentException(comment);
                                    comment.Return("the observable for the request");
                                });
                                classBlock.Block($"public Observable<OperationStatus<{method.ReturnTypeJva.ClientResponseTypeString}>> {method.Name}Async({method.MethodRequiredParameterDeclaration})", function =>
                                {
                                    foreach (ParameterJv param in method.RequiredNullableParameters)
                                    {
                                        function.If($"{param.Name} == null", ifBlock =>
                                        {
                                            ifBlock.Line($"throw new IllegalArgumentException(\"Parameter {param.Name} is required and cannot be null.\");");
                                        });
                                    }

                                    foreach (ParameterJv param in method.ParametersToValidate.Where(p => p.IsRequired))
                                    {
                                        function.Line($"Validator.validate({param.Name});");
                                    }

                                    foreach (ParameterJv parameter in method.LocalParameters)
                                    {
                                        if (!parameter.IsRequired)
                                        {
                                            function.Line($"final {parameter.WireType.Name} {parameter.WireName} = {parameter.WireType.GetDefaultValue(method) ?? "null"};");
                                        }
                                        if (parameter.IsConstant)
                                        {
                                            function.Line($"final {parameter.ClientType.ParameterVariant.Name} {parameter.Name} = {parameter.DefaultValue ?? "null"};");
                                        }
                                    }

                                    function.Line(method.BuildInputMappings(true));
                                    function.Line(method.RequiredParameterConversion);
                                    function.Return($"service.{method.Name}({method.MethodParameterApiInvocation})");
                                });

                                // -------------------------------
                                // Synchronous with all parameters
                                // -------------------------------
                                classBlock.MultipleLineComment(comment =>
                                {
                                    AddMethodSummaryAndDescription(comment, method);
                                    AddParameters(comment, nonConstantLocalParameters);
                                    ThrowsIllegalArgumentException(comment);
                                    ThrowsOperationException(comment, method.OperationExceptionTypeString);
                                    ThrowsRuntimeException(comment);
                                    if (method.ReturnType.Body != null)
                                    {
                                        comment.Return($"the {method.ReturnTypeResponseName.EscapeXmlComment()} object if successful.");
                                    }
                                });
                                classBlock.Block($"public {method.ReturnTypeResponseName} {method.Name}({method.MethodParameterDeclaration})", function =>
                                {
                                    if (method.ReturnTypeResponseName == "void")
                                    {
                                        function.Line($"{method.Name}Async({method.MethodParameterInvocation}).toBlocking().last();");
                                    }
                                    else
                                    {
                                        function.Return($"{method.Name}Async({method.MethodParameterInvocation}).toBlocking().last().result()");
                                    }
                                });
                                classBlock.Line();

                                // ----------------------------
                                // Callback with all parameters
                                // ----------------------------
                                classBlock.MultipleLineComment(comment =>
                                {
                                    AddMethodSummaryAndDescription(comment, method);
                                    AddParameters(comment, nonConstantLocalParameters);
                                    ParamServiceCallback(comment);
                                    ThrowsIllegalArgumentException(comment);
                                    comment.Return("the {{@link ServiceFuture}} object");
                                });
                                classBlock.Block($"public ServiceFuture<{method.ReturnTypeJva.ServiceFutureGenericParameterString}> {method.Name}Async({method.MethodParameterDeclarationWithCallback})", function =>
                                {
                                    function.Return($"ServiceFutureUtil.fromLRO({method.Name}Async({method.MethodParameterInvocation}, serviceCallback)");
                                });
                                classBlock.Line();

                                // ------------------------------
                                // Observable with all parameters
                                // ------------------------------
                                classBlock.MultipleLineComment(comment =>
                                {
                                    AddMethodSummaryAndDescription(comment, method);
                                    AddParameters(comment, nonConstantLocalParameters);
                                    ThrowsIllegalArgumentException(comment);
                                    comment.Return("the observable for the request");
                                });
                                classBlock.Block($"public Observable<OperationStatus<{method.ReturnTypeJva.ClientResponseTypeString}>> {method.Name}Async({method.MethodParameterDeclaration})", function =>
                                {
                                    foreach (ParameterJv param in method.RequiredNullableParameters)
                                    {
                                        function.If($"{param.Name} == null", ifBlock =>
                                        {
                                            ifBlock.Line($"throw new IllegalArgumentException(\"Parameter {param.Name} is required and cannot be null.\");");
                                        });
                                    }

                                    foreach (ParameterJv param in method.ParametersToValidate)
                                    {
                                        function.Line($"Validator.validate({param.Name});");
                                    }

                                    foreach (ParameterJv parameter in method.LocalParameters)
                                    {
                                        if (parameter.IsConstant)
                                        {
                                            function.Line($"final {parameter.ModelType.Name} {parameter.Name} = {parameter.DefaultValue ?? "null"};");
                                        }
                                    }

                                    function.Line(method.BuildInputMappings());
                                    function.Line(method.ParameterConversion);
                                    function.Return($"service.{method.Name}({method.MethodParameterApiInvocation})");
                                });
                            }
                        }
                    }
                    classBlock.Line();
                }
            });

            return javaFile;
        }

        public static JavaFile GetAzureServiceClientInterfaceJavaFile(CodeModelJva codeModel, Settings settings)
        {
            string interfaceName = codeModel.Name;

            JavaFile javaFile = GenerateJavaFileWithHeaderAndPackage(codeModel, null, settings, interfaceName);

            javaFile.Import(codeModel.InterfaceImports);

            javaFile.MultipleLineComment(comment =>
            {
                comment.Line($"The interface for {interfaceName} class.");
            });
            javaFile.PublicInterface(interfaceName, interfaceBlock =>
            {
                AddRestClientGetterSignature(interfaceBlock);
                interfaceBlock.Line();
                interfaceBlock.MultipleLineComment(comment =>
                {
                    comment.Line("Gets the User-Agent header for the client.");
                    comment.Line();
                    comment.Return("the user agent string.");
                });
                interfaceBlock.Line("String userAgent();");

                foreach (Property property in codeModel.PropertiesEx)
                {
                    string propertyDescription = property.Documentation;
                    string propertyName = property.Name;
                    string propertyNameCamelCase = propertyName.ToCamelCase();
                    string propertyType = property.ModelType.ServiceResponseVariant().Name;

                    interfaceBlock.Line();
                    interfaceBlock.MultipleLineComment(comment =>
                    {
                        comment.Line($"Gets {propertyDescription}.");
                        comment.Line();
                        comment.Return($"the {propertyName} value.");
                    });
                    interfaceBlock.Line($"{propertyType} {propertyNameCamelCase}();");
                    if (!property.IsReadOnly)
                    {
                        interfaceBlock.Line();
                        interfaceBlock.MultipleLineComment(comment =>
                        {
                            comment.Line($"Sets {propertyDescription}.");
                            comment.Line();
                            comment.Param(propertyNameCamelCase, $"the {propertyName} value.");
                            comment.Return("the service client itself");
                        });
                        interfaceBlock.Line($"{interfaceName} with{propertyName.ToPascalCase()}({propertyType} {propertyNameCamelCase});");
                    }
                }

                foreach (MethodGroupJv operation in codeModel.AllOperations)
                {
                    string operationType = operation.TypeName;

                    interfaceBlock.Line();
                    interfaceBlock.MultipleLineComment(comment =>
                    {
                        comment.Line($"Gets the {operationType} object to access its operations.");
                        comment.Return($"the {operationType} object.");
                    });
                    interfaceBlock.Line($"{operationType} {operation.Name.ToCamelCase()}();");
                }

                interfaceBlock.Line();
                AddInterfaceMethodSignatures(interfaceBlock, codeModel);
            });

            return javaFile;
        }

        public static JavaFile GetServiceClientJavaFile(CodeModelJv codeModel, Settings settings)
        {
            int maximumCommentWidth = GetMaximumCommentWidth(settings);

            string interfaceName = codeModel.Name.ToPascalCase();
            string className = $"{interfaceName}Impl";

            JavaFile javaFile = GenerateJavaFileWithHeaderAndPackage(codeModel, codeModel.ImplPackage, settings, className);

            javaFile.Import(codeModel.ImplImports);

            javaFile.MultipleLineComment(comment =>
            {
                comment.Line($"Initializes a new instance of the {interfaceName} class.");
            });
            javaFile.Block($"public class {className} extends ServiceClient implements {interfaceName}", classBlock =>
            {
                IEnumerable<MethodJv> rootMethods = codeModel.RootMethods;
                bool hasRootMethods = rootMethods.Any();
                string serviceClientType = codeModel.ServiceClientServiceType;
                string baseUrl = codeModel.BaseUrl;

                if (hasRootMethods)
                {
                    classBlock.MultipleLineComment(comment =>
                    {
                        comment.Line("The Retrofit service to perform REST calls.");
                    });
                    classBlock.Line($"private {serviceClientType} service;");
                }

                AddMemberVariablesWithGettersAndSettings(classBlock, codeModel.Properties, className);

                foreach (MethodGroupJv operation in codeModel.AllOperations)
                {
                    string operationType = operation.TypeName;
                    string operationName = operation.Name;

                    classBlock.Line();
                    classBlock.MultipleLineComment(comment =>
                    {
                        comment.Line($"The {operationType} object to access its operations.");
                    });
                    classBlock.Line($"private {operationType} {operationName};");
                    classBlock.Line();
                    classBlock.MultipleLineComment(comment =>
                    {
                        comment.Line($"Gets the {operationType} object to access its operations.");
                        comment.Return($"the {operationType} object.");
                    });
                    classBlock.Block($"public {operationType} {operationName}()", function =>
                    {
                        function.Return($"this.{operationName}");
                    });
                }

                classBlock.Line();

                string constructorDescription = $"Initializes an instance of {interfaceName} client.";
                classBlock.MultipleLineComment(comment =>
                {
                    comment.Line(constructorDescription);
                    comment.Line();
                    comment.Param("baseUrl", "the base URL of the host");
                });
                string baseUrlConstructorVisibility = codeModel.IsCustomBaseUri ? "private" : "public";
                classBlock.Block($"{baseUrlConstructorVisibility} {className}(String baseUrl)", constructor =>
                {
                    constructor.Line("super(baseUrl);");
                    constructor.Line("initialize();");
                });

                classBlock.Line();

                classBlock.MultipleLineComment(comment =>
                {
                    comment.Line(constructorDescription);
                });
                classBlock.Block($"public {className}()", constructor =>
                {
                    constructor.Line($"this(\"{baseUrl}\");");
                    constructor.Line("initialize();");
                });

                classBlock.Line();

                classBlock.MultipleLineComment(comment =>
                {
                    comment.Line(constructorDescription);
                    comment.Line();
                    comment.Param("restClient", "the REST client containing pre-configured settings");
                });
                classBlock.Block($"public {className}(RestClient restClient)", constructor =>
                {
                    constructor.Line("super(restClient);");
                    constructor.Line("initialize();");
                });

                classBlock.Line();

                classBlock.Block("private void initialize()", function =>
                {
                    foreach (Property property in codeModel.Properties.Where(p => p.DefaultValue != null))
                    {
                        function.Line($"this.{property.Name} = {property.DefaultValue};");
                    }

                    foreach (MethodGroupJv operation in codeModel.AllOperations)
                    {
                        function.Line($"this.{operation.Name} = new {operation.TypeName}Impl(this);");
                    }

                    if (hasRootMethods)
                    {
                        function.Line("initializeService();");
                    }
                });

                if (hasRootMethods)
                {
                    classBlock.Line();
                    classBlock.Block("private void initializeService()", function =>
                    {
                        function.Line($"service = RestProxy.create({serviceClientType}.class, restClient().baseURL(), httpClient(), serializerAdapter());");
                    });
                    classBlock.Line();
                    classBlock.WordWrappedMultipleLineComment(maximumCommentWidth, comment =>
                    {
                        comment.Line($"The interface defining all the services for {interfaceName} to be used by Retrofit to perform actually REST calls.");
                    });
                    classBlock.Annotation($"Host(\"{baseUrl}\")");
                    classBlock.Block($"interface {serviceClientType}", interfaceBlock =>
                    {
                        foreach (MethodJv method in codeModel.Methods)
                        {
                            if (method.RequestContentType == "multipart/form-data" || method.RequestContentType == "application/x-www-form-urlencoded")
                            {
                                interfaceBlock.SingleLineSlashSlashComment("@Multipart not supported by RestProxy");
                            }
                            else
                            {
                                interfaceBlock.Annotation($"Headers({{ \"x-ms-logging-context: {codeModel.FullyQualifiedDomainName} {method.Name}\" }})");
                            }
                            interfaceBlock.Annotation($"{method.HttpMethod.ToString().ToUpper()}(\"{method.Url.TrimStart('/')}\")");
                            if (method.ReturnType.Body.IsPrimaryType(KnownPrimaryType.Stream))
                            {
                                interfaceBlock.SingleLineSlashSlashComment("@Streaming not supported by RestProxy");
                            }
                            interfaceBlock.Line(method.ExpectedResponsesAnnotation);
                            if (method.DefaultResponse.Body != null)
                            {
                                interfaceBlock.Annotation($"UnexpectedResponseExceptionType({method.OperationExceptionTypeString}.class)");
                            }
                            interfaceBlock.Line($"Single<{method.RestResponseConcreteTypeName}> {method.Name}({method.MethodParameterApiDeclaration});");
                            interfaceBlock.Line();
                        }
                    });
                    classBlock.Line();

                    foreach (MethodJv method in rootMethods)
                    {
                        GenerateRootMethodFunctions(classBlock, method);

                        classBlock.Line();
                    }
                }
            });

            return javaFile;
        }

        public static JavaFile GetServiceClientInterfaceJavaFile(CodeModelJv codeModel, Settings settings)
        {
            string interfaceName = codeModel.Name;

            JavaFile javaFile = GenerateJavaFileWithHeaderAndPackage(codeModel, null, settings, interfaceName);

            javaFile.Import(codeModel.InterfaceImports);

            javaFile.MultipleLineComment(comment =>
            {
                comment.Line($"The interface for {interfaceName} class.");
            });
            javaFile.PublicInterface(interfaceName, interfaceBlock =>
            {
                AddRestClientGetterSignature(interfaceBlock);
                interfaceBlock.Line();
                interfaceBlock.MultipleLineComment(comment =>
                {
                    comment.Line("The default base URL.");
                });
                interfaceBlock.Line($"String DEFAULT_BASE_URL = \"{codeModel.BaseUrl}\";");

                foreach (Property property in codeModel.Properties)
                {
                    string propertyDescription = property.Documentation;
                    string propertyType = property.ModelType.ServiceResponseVariant().Name;
                    string propertyName = property.Name;
                    string propertyNameCamelCase = propertyName.ToCamelCase();

                    interfaceBlock.Line();
                    AddPropertyGetterComment(interfaceBlock, propertyDescription, propertyNameCamelCase);
                    interfaceBlock.Line($"{propertyType} {propertyNameCamelCase}();");

                    if (!property.IsReadOnly)
                    {
                        interfaceBlock.Line();
                        AddPropertySetterComment(interfaceBlock, propertyDescription, propertyNameCamelCase);
                        interfaceBlock.Line($"{interfaceName} with{propertyName.ToPascalCase()}({propertyType} {propertyNameCamelCase});");
                    }
                }

                foreach (MethodGroupJv operation in codeModel.AllOperations)
                {
                    string operationType = operation.TypeName;
                    string operationName = operation.Name;

                    interfaceBlock.Line();

                    interfaceBlock.MultipleLineComment(comment =>
                    {
                        comment.Line($"Gets the {operationType} object to access its operations.");
                        comment.Return($"the {operationType} object.");
                    });
                    interfaceBlock.Line($"{operationType} {operationName}();");
                }

                interfaceBlock.Line();

                AddInterfaceMethodSignatures(interfaceBlock, codeModel);
            });

            return javaFile;
        }

        private static void AddRestClientGetterSignature(JavaBlock interfaceBlock)
        {
            interfaceBlock.MultipleLineComment(comment =>
            {
                comment.Line("Gets the REST client.");
                comment.Line();
                comment.Return("the {@link RestClient} object.");
            });
            interfaceBlock.Line("RestClient restClient();");
        }

        private static void AddInterfaceMethodSignatures(JavaBlock interfaceBlock, CodeModelJv codeModel)
        {
            if (codeModel.RootMethods.Any())
            {
                foreach (MethodJv method in codeModel.RootMethods)
                {
                    string methodSummary = method.Summary;
                    string methodSummaryXmlEscaped = methodSummary?.EscapeXmlComment().Period();
                    string methodDescription = method.Description;
                    string methodDescriptionXmlEscaped = methodDescription?.EscapeXmlComment().Period();

                    IEnumerable<ParameterJv> methodParameters = method.LocalParameters.Where(p => !p.IsConstant);
                    if (methodParameters.Any(p => !p.IsRequired))
                    {
                        IEnumerable<ParameterJv> requiredMethodParameters = methodParameters.Where(p => p.IsRequired);

                        interfaceBlock.MultipleLineComment(comment =>
                        {
                            AddMethodSummaryAndDescription(comment, method);
                            AddParameters(comment, requiredMethodParameters);
                            ThrowsIllegalArgumentException(comment);
                            ThrowsOperationException(comment, method.OperationExceptionTypeString);
                            ThrowsRuntimeException(comment);
                            if (method.ReturnTypeResponseName.Else("void") != "void")
                            {
                                comment.Return($"the {method.ReturnTypeResponseName.EscapeXmlComment()} object if successful.");
                            }
                        });
                        interfaceBlock.Line($"{method.ReturnTypeResponseName} {method.Name}({method.MethodRequiredParameterDeclaration});");

                        interfaceBlock.Line();

                        interfaceBlock.MultipleLineComment(comment =>
                        {
                            AddMethodSummaryAndDescription(comment, method);
                            AddParameters(comment, requiredMethodParameters);
                            ParamServiceCallback(comment);
                            ThrowsIllegalArgumentException(comment);
                            comment.Return("the {@link ServiceFuture} object");
                        });
                        interfaceBlock.Line($"ServiceFuture<{method.ReturnTypeJv.ServiceFutureGenericParameterString}> {method.Name}Async({method.MethodRequiredParameterDeclarationWithCallback});");

                        interfaceBlock.Line();

                        interfaceBlock.MultipleLineComment(comment =>
                        {
                            AddMethodSummaryAndDescription(comment, method);
                            AddParameters(comment, requiredMethodParameters);
                            ThrowsIllegalArgumentException(comment);
                            if (method.ReturnTypeResponseName.Else("void") != "void")
                            {
                                comment.Return($"the observable to the {method.ReturnTypeResponseName} object");
                            }
                            else
                            {
                                comment.Return($"the {{@link Single<{method.ReturnTypeJv.ServiceResponseGenericParameterString}>}} object if successful.");
                            }
                        });
                        interfaceBlock.Line($"Single<{method.ReturnTypeJv.ServiceResponseGenericParameterString}> {method.Name}Async({method.MethodRequiredParameterDeclaration});");

                        if (method.ShouldGenerateBeginRestResponseMethod())
                        {
                            interfaceBlock.Line();

                            interfaceBlock.MultipleLineComment(comment =>
                            {
                                AddMethodSummaryAndDescription(comment, method);
                                AddParameters(comment, requiredMethodParameters);
                                ThrowsIllegalArgumentException(comment);
                                if (method.ReturnTypeResponseName.Else("void") != "void")
                                {
                                    comment.Return($"the observable to the {method.ReturnTypeResponseName} object");
                                }
                                else
                                {
                                    comment.Return($"the {{@link Single<{method.ReturnTypeJv.ServiceResponseGenericParameterString}>}} object if successful.");
                                }
                            });
                            interfaceBlock.Line($"Single<{method.RestResponseAbstractTypeName}> {method.Name}WithRestResponseAsync({method.MethodRequiredParameterDeclaration});");
                        }
                    }

                    interfaceBlock.MultipleLineComment(comment =>
                    {
                        AddMethodSummaryAndDescription(comment, method);
                        AddParameters(comment, methodParameters);
                        ThrowsIllegalArgumentException(comment);
                        ThrowsOperationException(comment, method.OperationExceptionTypeString);
                        ThrowsRuntimeException(comment);
                        if (method.ReturnTypeResponseName.Else("void") != "void")
                        {
                            comment.Return($"the {method.ReturnTypeResponseName.EscapeXmlComment()} object if successful.");
                        }
                    });
                    interfaceBlock.Line($"{method.ReturnTypeResponseName} {method.Name}({method.MethodParameterDeclaration});");

                    interfaceBlock.Line();

                    interfaceBlock.MultipleLineComment(comment =>
                    {
                        AddMethodSummaryAndDescription(comment, method);
                        AddParameters(comment, methodParameters);
                        ParamServiceCallback(comment);
                        ThrowsIllegalArgumentException(comment);
                        comment.Return("the {@link ServiceFuture} object");
                    });
                    interfaceBlock.Line($"ServiceFuture<{method.ReturnTypeJv.ServiceFutureGenericParameterString}> {method.Name}Async({method.MethodParameterDeclarationWithCallback});");

                    interfaceBlock.Line();

                    interfaceBlock.MultipleLineComment(comment =>
                    {
                        AddMethodSummaryAndDescription(comment, method);
                        AddParameters(comment, methodParameters);
                        ThrowsIllegalArgumentException(comment);
                        if (method.ReturnTypeResponseName.Else("void") != "void")
                        {
                            comment.Return($"the observable to the {method.ReturnTypeResponseName.EscapeXmlComment()} object");
                        }
                        else
                        {
                            comment.Return($"the {{@link Single<{method.ReturnTypeJv.ServiceResponseGenericParameterString}>}} object if successful.");
                        }
                    });
                    interfaceBlock.Line($"Single<{method.ReturnTypeJv.ServiceResponseGenericParameterString}> {method.Name}Async({method.MethodParameterDeclaration});");

                    interfaceBlock.Line();

                    if (method.ShouldGenerateBeginRestResponseMethod())
                    {
                        interfaceBlock.MultipleLineComment(comment =>
                        {
                            AddMethodSummaryAndDescription(comment, method);
                            AddParameters(comment, methodParameters);
                            ThrowsIllegalArgumentException(comment);
                            if (method.ReturnTypeResponseName.Else("void") != "void")
                            {
                                comment.Return($"the observable to the {method.ReturnTypeResponseName.EscapeXmlComment()} object");
                            }
                            else
                            {
                                comment.Return($"the {{@link Single<{method.ReturnTypeJv.ServiceResponseGenericParameterString}>}} object if successful.");
                            }
                        });
                    }
                    interfaceBlock.Line($"Single<{method.RestResponseAbstractTypeName}> {method.Name}WithRestResponseAsync({method.MethodParameterDeclaration});");

                    interfaceBlock.Line();

                    interfaceBlock.Line();
                }
            }
        }

        private static void AddMemberVariablesWithGettersAndSettings(JavaBlock classBlock, IEnumerable<Property> properties, string className)
        {
            foreach (Property property in properties)
            {
                string propertyDocumentation = property.Documentation.ToString().Period();
                string propertyType = property.ModelType.ServiceResponseVariant().Name;
                string propertyName = property.Name;
                string propertyNameCamelCase = propertyName.ToCamelCase();

                classBlock.Line();
                classBlock.SingleLineComment(propertyDocumentation);
                classBlock.Line($"private {propertyType} {propertyNameCamelCase};");
                classBlock.Line();
                AddPropertyGetterComment(classBlock, propertyDocumentation, propertyNameCamelCase);
                classBlock.Block($"public {propertyType} {propertyNameCamelCase}()", function =>
                {
                    function.Return($"this.{propertyNameCamelCase}");
                });

                if (!property.IsReadOnly)
                {
                    classBlock.Line();
                    AddPropertySetterComment(classBlock, propertyDocumentation, propertyNameCamelCase);
                    classBlock.Block($"public {className} with{propertyName.ToPascalCase()}({propertyType} {propertyNameCamelCase})", function =>
                    {
                        function.Line($"this.{propertyNameCamelCase} = {propertyNameCamelCase};");
                        function.Return("this");
                    });
                }
            }
        }

        private static void AddPropertyGetterComment(JavaBlock typeBlock, string propertyDocumentation, string propertyNameCamelCase)
        {
            typeBlock.MultipleLineComment(comment =>
            {
                comment.Line($"Gets {propertyDocumentation}");
                comment.Line();
                comment.Return($"the {propertyNameCamelCase} value.");
            });
        }

        private static void AddPropertySetterComment(JavaBlock typeBlock, string propertyDocumentation, string propertyNameCamelCase)
        {
            typeBlock.MultipleLineComment(comment =>
            {
                comment.Line($"Sets {propertyDocumentation}");
                comment.Line();
                comment.Param(propertyNameCamelCase, $"the {propertyNameCamelCase} value.");
                comment.Return("the service client itself");
            });
        }

        private static void AddMethodSummaryAndDescription(JavaMultipleLineComment comment, MethodJv method)
        {
            if (!string.IsNullOrEmpty(method.Summary))
            {
                comment.Line(method.Summary.EscapeXmlComment().Period());
            }
            if (!string.IsNullOrEmpty(method.Description))
            {
                comment.Line(method.Description.EscapeXmlComment().Period());
            }
            comment.Line();
        }

        private static void AddParameters(JavaMultipleLineComment comment, IEnumerable<ParameterJv> parameters)
        {
            foreach (ParameterJv param in parameters)
            {
                comment.Param(param.Name, param.Documentation.Else("the " + param.ModelType.Name + " value").EscapeXmlComment());
            }
        }

        private static void ParamServiceCallback(JavaMultipleLineComment comment)
        {
            comment.Param("serviceCallback", "the async ServiceCallback to handle successful and failed responses.");
        }

        private static void ThrowsIllegalArgumentException(JavaMultipleLineComment comment)
        {
            comment.Throws("IllegalArgumentException", "thrown if parameters fail the validation");
        }

        private static void ThrowsOperationException(JavaMultipleLineComment comment, string operationExceptionType)
        {
            comment.Throws(operationExceptionType, "thrown if the request is rejected by server");
        }

        private static void ThrowsRuntimeException(JavaMultipleLineComment comment)
        {
            comment.Throws("RuntimeException", "all other wrapped checked exceptions if the request fails to be sent");
        }

        public static JavaFile GetMethodGroupInterfaceJavaFile(CodeModel codeModel, Settings settings, MethodGroupJv methodGroup)
        {
            IEnumerable<string> imports = methodGroup.Methods.SelectMany(method => ((MethodJv)method).InterfaceImports);
            
            string interfaceName = methodGroup.TypeName;

            IEnumerable<JavaMethod> methods = methodGroup.Methods.SelectMany(ParseMethod);

            int maximumCommentWidth = GetMaximumCommentWidth(settings);

            JavaFile javaFile = GenerateJavaFileWithHeaderAndPackage(codeModel, null, settings, interfaceName);
            javaFile.Import(imports);
            javaFile.WordWrappedMultipleLineComment(maximumCommentWidth, (comment) =>
            {
                comment.Line($"An instance of this class provides access to all the operations defined in {interfaceName}.");
            });
            javaFile.PublicInterface(interfaceName, (typeBlock) =>
            {
                foreach (JavaMethod method in methods)
                {
                    typeBlock.MultipleLineComment((comment) =>
                    {
                        comment.Line(method.Description);
                        comment.Line();
                        if (method.Parameters != null)
                        {
                            foreach (JavaMethodParameter parameter in method.Parameters)
                            {
                                comment.Param(parameter.Name, parameter.Description);
                            }
                        }
                        if (method.Throws != null)
                        {
                            foreach (JavaThrow methodThrow in method.Throws)
                            {
                                comment.Throws(methodThrow.ExceptionTypeName, methodThrow.Description);
                            }
                        }
                        if (!string.IsNullOrEmpty(method.Return.Description))
                        {
                            comment.Return(method.Return.Description);
                        }
                    });
                    typeBlock.Line($"{method.Return.Type} {method.Name}({string.Join(", ", method.Parameters.Select(parameter => parameter.Declaration))});");
                    typeBlock.Line();
                }
            });
            return javaFile;
        }

        private static IEnumerable<JavaMethod> ParseMethod(Method method)
        {
            string description = "";
            if(!string.IsNullOrEmpty(method.Summary))
            {
                description += method.Summary.EscapeXmlComment().Period();
            }
            if(!string.IsNullOrEmpty(method.Description))
            {
                if (!string.IsNullOrEmpty(description))
                {
                    description += "\n";
                }
                description += method.Description.EscapeXmlComment().Period();
            }

            MethodJv methodJv = method as MethodJv;
            MethodJva methodJva = methodJv as MethodJva;

            JavaThrow operationExceptionThrow = new JavaThrow(methodJv.OperationExceptionTypeString, "thrown if the request is rejected by server");
            JavaThrow runtimeExceptionThrow = new JavaThrow("RuntimeException", "all other wrapped checked exceptions if the request fails to be sent");
            JavaThrow illegalArgumentExceptionThrow = new JavaThrow("IllegalArgumentException", "thrown if parameters fail the validation");

            string syncReturnType = methodJv.ReturnTypeResponseName;
            string xmlEscapedSyncReturnType = syncReturnType.EscapeXmlComment();
            string asyncInnerReturnType = methodJv.ReturnTypeJv.GenericBodyClientTypeString;
            string serviceFutureReturnType = $"ServiceFuture<{asyncInnerReturnType}>";
            string asyncReturnType = methodJva != null ? methodJva.AsyncClientReturnTypeString : $"Single<{asyncInnerReturnType}>";
            string asyncRestResponseReturnType = $"Single<{methodJv.RestResponseAbstractTypeName}>";
            
            JavaMethodReturn syncReturn = new JavaMethodReturn(
                syncReturnType,
                syncReturnType == "void"
                    ? null
                    : $"the {xmlEscapedSyncReturnType} object if successful.");

            JavaMethodReturn callbackReturn = new JavaMethodReturn(
                serviceFutureReturnType,
                $"the {{@link {serviceFutureReturnType.EscapeXmlComment()}}} object");

            JavaMethodReturn asyncReturn = new JavaMethodReturn(
                asyncReturnType,
                $"the {{@link {asyncReturnType.EscapeXmlComment()}}} object if successful.");

            JavaMethodReturn asyncRestResponseReturn = new JavaMethodReturn(
                asyncRestResponseReturnType,
                $"the {{@link {asyncRestResponseReturnType.EscapeXmlComment()}}} object if successful.");

            string methodName = method.Name;
            string asyncMethodName = $"{methodName}Async";
            string asyncRestResponseMethodName = $"{methodName}WithRestResponseAsync";

            IEnumerable<ParameterJv> nonConstantParameters = methodJv.LocalParameters.Where(p => !p.IsConstant);
            IEnumerable<ParameterJv> nonConstantRequiredParameters = nonConstantParameters.Where(p => p.IsRequired);
            IEnumerable<JavaMethodParameter> parameters = nonConstantParameters.Select(ParseParameter);
            IEnumerable<JavaMethodParameter> requiredParameters = nonConstantRequiredParameters.Select(ParseParameter);

            JavaMethodParameter callbackParameter = new JavaMethodParameter(
                "the async ServiceCallback to handle successful and failed responses.",
                $"ServiceCallback<{asyncInnerReturnType}>",
                "serviceCallback",
                final: true);

            bool shouldGenerateCallbackMethod =
                methodJva == null ||
                (!methodJva.IsPagingOperation &&
                 !methodJva.IsPagingNextOperation);

            bool shouldGenerateRestResponseMethod =
                methodJva == null ||
                (!methodJva.IsLongRunningOperation &&
                 !methodJva.IsPagingOperation &&
                 !methodJva.IsPagingNextOperation);

            List<JavaMethod> javaMethods = new List<JavaMethod>();

            Action<IEnumerable<JavaMethodParameter>> addMethods = (IEnumerable<JavaMethodParameter> methodParameters) =>
            {
                // Sync
                javaMethods.Add(new JavaMethod(
                    description,
                    new[] { illegalArgumentExceptionThrow, operationExceptionThrow, runtimeExceptionThrow },
                    syncReturn,
                    methodName,
                    methodParameters));

                if (shouldGenerateCallbackMethod)
                {
                    // Callback
                    javaMethods.Add(new JavaMethod(
                        description,
                        new[] { illegalArgumentExceptionThrow },
                        callbackReturn,
                        asyncMethodName,
                        methodParameters.Concat(new[] { callbackParameter })));
                }

                // Async
                javaMethods.Add(new JavaMethod(
                    description,
                    new[] { illegalArgumentExceptionThrow },
                    asyncReturn,
                    asyncMethodName,
                    methodParameters));

                if (shouldGenerateRestResponseMethod)
                {
                    // RestResponse Async
                    javaMethods.Add(new JavaMethod(
                        description,
                        new[] { illegalArgumentExceptionThrow },
                        asyncRestResponseReturn,
                        asyncRestResponseMethodName,
                        methodParameters));
                }
            };

            if (nonConstantParameters.Any(p => !p.IsRequired))
            {
                addMethods(requiredParameters);
            }

            addMethods(parameters);

            return javaMethods;
        }

        private static JavaMethodParameter ParseParameter(ParameterJv parameter)
        {
            string description = parameter.Documentation.Else($"the {parameter.ModelType.Name} value").EscapeXmlComment();
            string type = parameter.ClientType.ParameterVariant.Name;
            string name = parameter.Name;
            return new JavaMethodParameter(description, type, name);
        }

        public static IEnumerable<JavaFile> GetPackageInfoJavaFiles(CodeModel codeModel, Settings settings, IEnumerable<string> subPackages)
        {
            List<JavaFile> packageInfoJavaFiles = new List<JavaFile>();

            string headerComment = settings.Header;

            int maximumHeaderCommentWidth = settings.MaximumCommentColumns;

            string title = codeModel.Name;
            string description = codeModel.Documentation;

            foreach (string subPackage in subPackages)
            {
                string package = GetPackage(codeModel, subPackage);
                string folderPath = GetFolderPath(package);

                string filePath = GetFilePath(folderPath, "package-info");
                JavaFile javaFile = new JavaFile(filePath);
                
                if (!string.IsNullOrEmpty(headerComment))
                {
                    javaFile.WordWrappedMultipleLineSlashSlashComment(maximumHeaderCommentWidth, (comment) =>
                    {
                        comment.Line(headerComment);
                    });
                    javaFile.Line();
                }

                javaFile.WordWrappedMultipleLineComment(maximumHeaderCommentWidth, (comment) =>
                {
                    if (string.IsNullOrEmpty(subPackage))
                    {
                        comment.Line($"This package contains the classes for {title}.");
                    }
                    else
                    {
                        comment.Line($"This package contains the {subPackage} classes for {title}.");
                    }

                    if (!string.IsNullOrEmpty(description))
                    {
                        comment.Line(description.Period());
                    }
                });

                javaFile.Package(package);

                packageInfoJavaFiles.Add(javaFile);
            }

            return packageInfoJavaFiles;
        }

        public static IEnumerable<JavaFile> GetModelJavaFiles(CodeModel codeModel, Settings settings)
        {
            List<JavaFile> exceptionJavaFiles = new List<JavaFile>();

            int maximumCommentWidth = GetMaximumCommentWidth(settings);

            foreach (CompositeTypeJv modelType in codeModel.ModelTypes.Union(codeModel.HeaderTypes))
            {
                bool shouldGenerate = true;

                if (modelType is CompositeTypeJva modelTypeJva)
                {
                    bool isExternalExtension =
                        modelType.Extensions.ContainsKey(AzureExtensions.ExternalExtension) &&
                        (bool)modelType.Extensions[AzureExtensions.ExternalExtension];

                    shouldGenerate = !isExternalExtension && !modelTypeJva.IsResource;
                }

                if (shouldGenerate)
                {
                    List<string> imports = new List<string>();
                    imports.AddRange(modelType.Properties.SelectMany(pm => (pm as PropertyJv).Imports));

                    if (modelType.Properties.Any(p => !p.GetJsonProperty().IsNullOrEmpty()))
                    {
                        imports.Add("com.fasterxml.jackson.annotation.JsonProperty");
                    }

                    if (modelType.Properties.Any(p => p.XmlIsAttribute))
                    {
                        imports.Add("com.fasterxml.jackson.dataformat.xml.annotation.JacksonXmlProperty");
                    }

                    // For polymorphism
                    if (modelType.BaseIsPolymorphic)
                    {
                        imports.Add("com.fasterxml.jackson.annotation.JsonTypeInfo");
                        imports.Add("com.fasterxml.jackson.annotation.JsonTypeName");
                        if (modelType.SubTypes.Any())
                        {
                            imports.Add("com.fasterxml.jackson.annotation.JsonSubTypes");
                        }
                    }

                    // For flattening
                    if (modelType.NeedsFlatten)
                    {
                        imports.Add("com.microsoft.rest.v2.serializer.JsonFlatten");
                    }

                    if (modelType is CompositeTypeJva azureModelType)
                    {
                        foreach (Property property in azureModelType.Properties)
                        {
                            if (property.ModelType.IsResource())
                            {
                                imports.Add($"com.microsoft.azure.v2.{property.ModelType.Name}");
                            }
                        }

                        if (azureModelType.BaseModelType != null && (azureModelType.BaseModelType.Name == "Resource" || azureModelType.BaseModelType.Name == "SubResource"))
                        {
                            imports.Add("com.microsoft.azure.v2." + azureModelType.BaseModelType.Name);
                        }

                        if (azureModelType is CompositeTypeJvaf fluentModelType)
                        {
                            if (fluentModelType.BaseModelType != null && fluentModelType.BaseModelType.Name.ToString().EndsWith("Inner", StringComparison.Ordinal) ^ fluentModelType.IsInnerModel)
                            {
                                imports.AddRange(fluentModelType.BaseModelType.ImportSafe());
                            }
                        }
                    }

                    string classComment;
                    if (string.IsNullOrEmpty(modelType.Summary) && string.IsNullOrEmpty(modelType.Documentation))
                    {
                        classComment = $"The {modelType.Name} model.";
                    }
                    else
                    {
                        classComment = $"{modelType.Summary.EscapeXmlComment().Period()}{modelType.Documentation.EscapeXmlComment().Period()}";
                    }

                    List<string> classAnnotations = new List<string>();
                    if (modelType.BaseIsPolymorphic)
                    {
                        classAnnotations.Add($"JsonTypeInfo(use = JsonTypeInfo.Id.NAME, include = JsonTypeInfo.As.PROPERTY, property = \"{modelType.BasePolymorphicDiscriminator}\")");
                        classAnnotations.Add($"JsonTypeName(\"{modelType.SerializedName}\")");

                        List<CompositeType> types = modelType.SubTypes.ToList();
                        if (types.Any())
                        {
                            StringBuilder subTypeAnnotationBuilder = new StringBuilder();
                            subTypeAnnotationBuilder.AppendLine("JsonSubTypes({");

                            Func<CompositeType, bool, string> getSubTypeAnnotation = (CompositeType subType, bool isLast) =>
                            {
                                string subTypeAnnotation = $"@JsonSubTypes.Type(name = \"{subType.SerializedName}\", value = {subType.Name}.class)";
                                if (!isLast)
                                {
                                    subTypeAnnotation += ",";
                                }
                                return subTypeAnnotation;
                            };

                            foreach (CompositeType subType in types.SkipLast(1))
                            {
                                subTypeAnnotationBuilder.AppendLine(getSubTypeAnnotation(subType, false));
                            }
                            subTypeAnnotationBuilder.AppendLine(getSubTypeAnnotation(types.Last(), true));

                            subTypeAnnotationBuilder.Append("})");

                            classAnnotations.Add(subTypeAnnotationBuilder.ToString());
                        }
                    }

                    if (modelType.NeedsFlatten)
                    {
                        classAnnotations.Add("JsonFlatten");
                    }

                    string className = modelType.Name;

                    string baseTypeName = modelType.BaseModelType?.Name?.Value;

                    IEnumerable<JavaMemberVariable> memberVariables = modelType.Properties.Select((Property property) =>
                    {
                        string comment;
                        if (string.IsNullOrEmpty(property.Summary) && string.IsNullOrEmpty(property.Documentation))
                        {
                            comment = $"The {property.Name} property.";
                        }
                        else
                        {
                            string summary = property.Summary.EscapeXmlComment().Period();
                            string documentation = property.Documentation.EscapeXmlComment().Period();

                            comment = summary;
                            if (!string.IsNullOrEmpty(documentation))
                            {
                                if (!string.IsNullOrEmpty(comment))
                                {
                                    comment += "\n";
                                }
                                comment += documentation;
                            }
                        }

                        string annotation = null;
                        string jsonSetting = property.GetJsonProperty();
                        if (!string.IsNullOrEmpty(jsonSetting))
                        {
                            if (property.XmlIsAttribute)
                            {
                                annotation = $"JacksonXmlProperty(localName = \"{property.SerializedName}\", isAttribute = true)";
                            }
                            else
                            {
                                annotation = $"JsonProperty({jsonSetting})";
                            }
                        }

                        bool isConstant = property.IsConstant;
                        bool isReadOnly = property.IsReadOnly;

                        bool isPrimitive = !(property.ModelType is CompositeType);
                        JavaType wireType = new JavaType(property.ModelType.Name, isPrimitive);
                        JavaType clientType = new JavaType(((IModelTypeJv)property.ModelType).ResponseVariant.Name, isPrimitive);

                        string name = property.Name;

                        string defaultValue;
                        try
                        {
                            defaultValue = property.DefaultValue;
                        }
                        catch (NotSupportedException)
                        {
                            defaultValue = null;
                        }

                        return new JavaMemberVariable(comment, annotation, isConstant, isReadOnly, wireType, clientType, name, defaultValue);
                    });

                    JavaFile javaFile = GenerateJavaFileWithHeaderAndPackage(codeModel, modelType.ModelsPackage, settings, className);
                    javaFile.Import(imports);
                    javaFile.WordWrappedMultipleLineComment(maximumCommentWidth, (comment) =>
                    {
                        comment.Line(classComment);
                    });
                    javaFile.Annotation(classAnnotations);

                    string classNameWithBaseType = className;
                    if (!string.IsNullOrEmpty(baseTypeName))
                    {
                        classNameWithBaseType += $" extends {baseTypeName}";
                    }
                    javaFile.PublicClass(classNameWithBaseType, (classBlock) =>
                    {
                        if (memberVariables != null && memberVariables.Any())
                        {
                            foreach (JavaMemberVariable memberVariable in memberVariables)
                            {
                                classBlock.WordWrappedMultipleLineComment(maximumCommentWidth, (comment) =>
                                {
                                    comment.Line(memberVariable.Comment);
                                });
                                classBlock.Annotation(memberVariable.Annotation);
                                classBlock.Line($"private {memberVariable.WireType.Name} {memberVariable.Name};");
                                classBlock.Line();
                            }

                            IEnumerable<JavaMemberVariable> constantMemberVariables = memberVariables.Where((memberVariable) => memberVariable.IsConstant);
                            if (constantMemberVariables.Any())
                            {
                                classBlock.WordWrappedMultipleLineComment(maximumCommentWidth, (comment) =>
                                {
                                    comment.Line($"Creates an instance of {className} class.");
                                });
                                classBlock.Block($"public {className}()", (constructor) =>
                                {
                                    foreach (JavaMemberVariable memberVariable in constantMemberVariables)
                                    {
                                        JavaType type = memberVariable.WireType;
                                        if (!type.IsPrimitive)
                                        {
                                            constructor.Line($"{memberVariable.Name} = new {type.Name}();");
                                        }
                                        else
                                        {
                                            constructor.Line($"{memberVariable.Name} = {memberVariable.DefaultValue};");
                                        }
                                    }
                                });
                                classBlock.Line();
                            }

                            foreach (JavaMemberVariable memberVariable in memberVariables)
                            {
                                string variableName = memberVariable.Name;
                                JavaType clientType = memberVariable.ClientType;
                                JavaType wireType = memberVariable.WireType;
                                string clientTypeName = clientType.Name;
                                bool clientTypeDifferentFromWireType = !clientType.Equals(memberVariable.WireType);

                                classBlock.WordWrappedMultipleLineComment(maximumCommentWidth, (comment) =>
                                {
                                    comment.Line($"Get the {variableName} value.");
                                    comment.Line();
                                    comment.Return($"the {variableName} value");
                                });
                                classBlock.Block($"public {clientTypeName} {variableName}()", (methodBlock) =>
                                {
                                    if (clientTypeDifferentFromWireType)
                                    {
                                        methodBlock.If($"this.{variableName} == null", (ifBlock) =>
                                        {
                                            ifBlock.Return("null");
                                        });
                                        methodBlock.Return(wireType.ConvertTo(clientType, $"this.{variableName}"));
                                    }
                                    else
                                    {
                                        methodBlock.Return($"this.{variableName}");
                                    }
                                });
                                classBlock.Line();

                                if (!memberVariable.IsReadOnly)
                                {
                                    classBlock.WordWrappedMultipleLineComment(maximumCommentWidth, (comment) =>
                                    {
                                        comment.Line($"Set the {variableName} value.");
                                        comment.Line();
                                        comment.Param(variableName, $"the {variableName} value to set");
                                        comment.Return($"the {className} object itself.");
                                    });
                                    classBlock.Block($"public {className} with{variableName.ToPascalCase()}({clientTypeName} {variableName})", (methodBlock) =>
                                    {
                                        if (clientTypeDifferentFromWireType)
                                        {
                                            methodBlock.If($"{variableName} == null", (ifBlock) =>
                                            {
                                                ifBlock.Line($"this.{variableName} = null;");
                                            })
                                            .Else((elseBlock) =>
                                            {
                                                elseBlock.Line($"this.{variableName} = {clientType.ConvertTo(wireType, variableName)};");
                                            });
                                        }
                                        else
                                        {
                                            methodBlock.Line($"this.{variableName} = {variableName};");
                                        }
                                        methodBlock.Return("this");
                                    });
                                    classBlock.Line();
                                }
                            }
                        }
                    });
                    
                    exceptionJavaFiles.Add(javaFile);
                }
            }

            return exceptionJavaFiles;
        }

        public static IEnumerable<JavaFile> GetExceptionJavaFiles(CodeModelJv codeModel, Settings settings)
        {
            List<JavaFile> exceptionJavaFiles = new List<JavaFile>();

            string headerComment = settings.Header;

            int maximumHeaderCommentWidth = settings.MaximumCommentColumns;

            foreach (CompositeTypeJv exceptionType in codeModel.ErrorTypes)
            {
                string exceptionBodyTypeName = exceptionType.Name;
                string exceptionName = exceptionType.ExceptionTypeDefinitionName;

                // Skip any exceptions that are named "CloudErrorException" or have a body named
                // "CloudError" because those types already exist in the runtime.
                if (exceptionBodyTypeName != "CloudError" && exceptionName != "CloudErrorException")
                {
                    JavaFile javaFile = GenerateJavaFileWithHeaderAndPackage(codeModel, exceptionType.ModelsPackage, settings, exceptionName);
                    javaFile.Import("com.microsoft.rest.v2.RestException",
                                    "com.microsoft.rest.v2.http.HttpResponse");
                    javaFile.MultipleLineComment((comment) =>
                    {
                        comment.Line($"Exception thrown for an invalid response with {exceptionBodyTypeName} information.");
                    });
                    javaFile.Block($"public class {exceptionName} extends RestException", (classBlock) =>
                    {
                        classBlock.MultipleLineComment((comment) =>
                        {
                            comment.Line($"Initializes a new instance of the {exceptionName} class.")
                                .Line()
                                .Param("message", "the exception message or the response content if a message is not available")
                                .Param("response", "the HTTP response");
                        });
                        classBlock.Block($"public {exceptionName}(final String message, HttpResponse response)", (constructorBlock) =>
                        {
                            constructorBlock.Line("super(message, response);");
                        });
                        classBlock.Line();
                        classBlock.MultipleLineComment((comment) =>
                        {
                            comment.Line($"Initializes a new instance of the {exceptionName} class.");
                            comment.Line();
                            comment.Param("message", "the exception message or the response content if a message is not available");
                            comment.Param("response", "the HTTP response");
                            comment.Param("body", "the deserialized response body");
                        });
                        classBlock.Block($"public {exceptionName}(final String message, final HttpResponse response, final {exceptionBodyTypeName} body)", (constructorBlock) =>
                        {
                            constructorBlock.Line("super(message, response, body);");
                        });
                        classBlock.Line();
                        classBlock.Annotation("Override");
                        classBlock.Block($"public {exceptionBodyTypeName} body()", (methodBlock) =>
                        {
                            methodBlock.Return($"({exceptionBodyTypeName}) super.body()");
                        });
                    });

                    exceptionJavaFiles.Add(javaFile);
                }
            }

            return exceptionJavaFiles;
        }

        public static IEnumerable<JavaFile> GetEnumJavaFiles(CodeModelJv codeModel, Settings settings)
        {
            List<JavaFile> enumJavaFiles = new List<JavaFile>();

            foreach (EnumType enumType in codeModel.EnumTypes)
            {
                string enumName = enumType.Name;
                string enumTypeComment = $"Defines values for {enumName}.";

                IEnumerable<JavaEnumValue> enumValues = enumType.Values
                    .Select((EnumValue value) => new JavaEnumValue(value.MemberName, value.SerializedName));

                JavaFile javaFile = GenerateJavaFileWithHeaderAndPackage(codeModel, codeModel.ModelsPackage, settings, enumName);
                if (enumType.ModelAsString)
                {
                    javaFile.Import("java.util.Collection",
                                    "com.fasterxml.jackson.annotation.JsonCreator",
                                    "com.microsoft.rest.v2.ExpandableStringEnum");
                    javaFile.MultipleLineComment(comment =>
                    {
                        comment.Line(enumTypeComment);
                    });
                    javaFile.PublicFinalClass($"{enumName} extends ExpandableStringEnum<{enumName}>", (classBlock) =>
                    {
                        foreach (JavaEnumValue value in enumValues)
                        {
                            classBlock.SingleLineComment($"Static value {value.Value} for {enumName}.")
                                    .Line($"public static final {enumName} {value.Name} = fromString(\"{value.Value}\");")
                                    .Line();
                        }

                        classBlock.MultipleLineComment((comment) =>
                        {
                            comment.Line($"Creates or finds a {enumName} from its string representation.")
                                .Param("name", "a name to look for")
                                .Return($"the corresponding {enumName}");
                        });
                        classBlock.Annotation("JsonCreator");
                        classBlock.Block($"public static {enumName} fromString(String name)", (function) =>
                        {
                            function.Return($"fromString(name, {enumName}.class)");
                        });
                        classBlock.Line();
                        classBlock.MultipleLineComment((comment) =>
                        {
                            comment.Return($"known {enumName} values");
                        });
                        classBlock.Block($"public static Collection<{enumName}> values()", (function) =>
                        {
                            function.Return($"values({enumName}.class)");
                        });
                    });
                }
                else
                {
                    javaFile.Import("com.fasterxml.jackson.annotation.JsonCreator",
                                    "com.fasterxml.jackson.annotation.JsonValue");
                    javaFile.MultipleLineComment(comment =>
                    {
                        comment.Line(enumTypeComment);
                    });
                    javaFile.PublicEnum(enumName, (enumBlock) =>
                    {
                        if (enumValues.Any())
                        {
                            Action<JavaEnumValue,bool> enumValue = (JavaEnumValue value, bool isLast) =>
                            {
                                enumBlock.SingleLineComment($"Enum value {value.Value}.")
                                    .Line($"{value.Name}(\"{value.Value}\")" + (isLast ? ";" : ","))
                                    .Line();
                            };

                            foreach (JavaEnumValue value in enumValues.SkipLast(1))
                            {
                                enumValue(value, false);
                            }
                            enumValue(enumValues.Last(), true);
                        }

                        enumBlock.SingleLineComment($"The actual serialized value for a {enumName} instance.");
                        enumBlock.Line("private String value;");
                        enumBlock.Line();
                        enumBlock.Block($"{enumName}(String value)", (constructor) =>
                        {
                            constructor.Line("this.value = value;");
                        });
                        enumBlock.Line();
                        enumBlock.MultipleLineComment((comment) =>
                        {
                            comment.Line($"Parses a serialized value to a {enumName} instance.");
                            comment.Line()
                                    .Param("value", "the serialized value to parse.")
                                    .Return($"the parsed {enumName} object, or null if unable to parse.");
                        });
                        enumBlock.Annotation("JsonCreator");
                        enumBlock.Block($"public static {enumName} fromString(String value)", (function) =>
                        {
                            function.Line($"{enumName}[] items = {enumName}.values();");
                            function.Block($"for ({enumName} item : items)", (foreachBlock) =>
                            {
                                foreachBlock.If("item.toString().equalsIgnoreCase(value)", (ifBlock) =>
                                {
                                    ifBlock.Return("item");
                                });
                            });
                            function.Return("null");
                        });
                        enumBlock.Line();
                        enumBlock.Annotation("JsonValue",
                                             "Override");
                        enumBlock.Block("public String toString()", (function) =>
                        {
                            function.Return("this.value");
                        });
                    });
                }

                enumJavaFiles.Add(javaFile);
            }

            return enumJavaFiles;
        }

        private static string GetPackage(CodeModel codeModel, string packageSuffix = null)
        {
            string package = codeModel.Namespace.ToLowerInvariant();
            if (!string.IsNullOrEmpty(packageSuffix))
            {
                package = $"{package}.{packageSuffix.Trim('.')}";
            }
            return package;
        }

        private static string GetFolderPath(string package)
        {
            return Path.Combine("src", "main", "java", package.Replace('.', Path.DirectorySeparatorChar));
        }

        private static string GetFilePath(string folderPath, string fileNameWithoutExtension)
        {
            string result = Path.Combine(folderPath, $"{fileNameWithoutExtension}.java");

            result = result.Replace('\\', '/');
            result = result.Replace("//", "/");

            return result;
        }

        private static int GetMaximumCommentWidth(Settings settings)
        {
            return settings.MaximumCommentColumns;
        }

        private static JavaFile GenerateJavaFileWithHeaderAndPackage(CodeModel codeModel, string subPackage, Settings settings, string fileNameWithoutExtension)
        {
            string package = GetPackage(codeModel, subPackage);
            string folderPath = GetFolderPath(package);

            string headerComment = settings.Header;

            int maximumHeaderCommentWidth = GetMaximumCommentWidth(settings);

            string filePath = GetFilePath(folderPath, fileNameWithoutExtension);
            JavaFile javaFile = new JavaFile(filePath);

            if (!string.IsNullOrEmpty(headerComment))
            {
                javaFile.WordWrappedMultipleLineComment(maximumHeaderCommentWidth, (comment) =>
                {
                    comment.Line(headerComment);
                });
                javaFile.Line();
            }

            if (!string.IsNullOrEmpty(package))
            {
                javaFile.Package(package);
                javaFile.Line();
            }

            return javaFile;
        }

        private static void GenerateRootMethodFunctions(JavaBlock classBlock, MethodJv method)
        {
            ParameterVariants parameterVariants = method.ParameterVariants;
            ParameterJv callbackParam = method.CallbackParam;

            if (parameterVariants.HasOptionalParameters)
            {
                // --------------------------------------
                // Synchronous, Body, required parameters
                // --------------------------------------
                classBlock.Text(method.Javadoc(parameterVariants.RequiredParameters, method.SyncExceptionDocumentation, method.SyncReturnDocumentation));
                classBlock.Text(method.SyncImpl(parameterVariants.RequiredParameters));
                classBlock.Line();

                // -----------------------------------
                // Callback, Body, required parameters
                // -----------------------------------
                classBlock.Text(method.Javadoc(parameterVariants.RequiredParameters.ConcatSingleItem(callbackParam), method.AsyncExceptionDocumentation, method.CallbackReturnDocumentation));
                classBlock.Text(method.CallbackImpl(parameterVariants.RequiredParameters, callbackParam));
                classBlock.Line();

                // ---------------------------------------------
                // Observable, RestResponse, required parameters
                // ---------------------------------------------
                classBlock.Text(method.Javadoc(parameterVariants.RequiredParameters, method.AsyncExceptionDocumentation, method.ObservableReturnDocumentation));
                classBlock.Text(method.ObservableRestResponseImpl(parameterVariants.RequiredParameters, takeOnlyRequiredParameters: true));
                classBlock.Line();

                // -------------------------------------
                // Observable, Body, required parameters
                // -------------------------------------
                classBlock.Text(method.Javadoc(parameterVariants.RequiredParameters, method.AsyncExceptionDocumentation, method.ObservableReturnDocumentation));
                classBlock.Text(method.ObservableImpl(parameterVariants.RequiredParameters));
                classBlock.Line();
            }

            // ---------------------------------
            // Synchronous, Body, all parameters
            // ---------------------------------
            classBlock.Text(method.Javadoc(parameterVariants.AllParameters, method.SyncExceptionDocumentation, method.SyncReturnDocumentation));
            classBlock.Text(method.SyncImpl(parameterVariants.AllParameters));
            classBlock.Line();

            // ------------------------------
            // Callback, Body, all parameters
            // ------------------------------
            classBlock.Text(method.Javadoc(parameterVariants.AllParameters.ConcatSingleItem(callbackParam), method.AsyncExceptionDocumentation, method.CallbackReturnDocumentation));
            classBlock.Text(method.CallbackImpl(parameterVariants.AllParameters, callbackParam));
            classBlock.Line();

            // ----------------------------------------
            // Observable, RestResponse, all parameters
            // ----------------------------------------
            classBlock.Text(method.Javadoc(parameterVariants.AllParameters, method.AsyncExceptionDocumentation, method.ObservableReturnDocumentation));
            classBlock.Text(method.ObservableRestResponseImpl(parameterVariants.AllParameters, takeOnlyRequiredParameters: false));
            classBlock.Line();

            // --------------------------------
            // Observable, Body, all parameters
            // --------------------------------
            classBlock.Text(method.Javadoc(parameterVariants.AllParameters, method.AsyncExceptionDocumentation, method.ObservableReturnDocumentation));
            classBlock.Text(method.ObservableImpl(parameterVariants.AllParameters));
            classBlock.Line();
        }
    }
}