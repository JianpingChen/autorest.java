/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 */

package com.azure.autorest.fluent.model.clientmodel.fluentmodel.method;

import com.azure.autorest.fluent.model.clientmodel.FluentResourceModel;
import com.azure.autorest.fluent.model.clientmodel.ModelNaming;
import com.azure.autorest.fluent.model.clientmodel.fluentmodel.create.DefinitionStage;
import com.azure.autorest.model.clientmodel.ClassType;
import com.azure.autorest.model.clientmodel.ClientMethodParameter;
import com.azure.autorest.model.clientmodel.ReturnValue;
import com.azure.autorest.model.javamodel.JavaJavadocComment;
import com.azure.autorest.template.prototype.MethodTemplate;
import com.azure.autorest.util.CodeNamer;

import java.util.Set;

public class FluentMethodParameterMethod extends FluentMethod {

    private final ClientMethodParameter methodParameter;

    public FluentMethodParameterMethod(FluentResourceModel model, FluentMethodType type,
                                       DefinitionStage stage, ClientMethodParameter methodParameter) {
        super(model, type);

        this.methodParameter = methodParameter;

        this.name = CodeNamer.getModelNamer().modelPropertySetterName(methodParameter.getName());
        this.description = String.format("Specifies the %1$s property: %2$s.", methodParameter.getName(), methodParameter.getDescription());
        this.interfaceReturnValue = new ReturnValue("the next definition stage.", new ClassType.Builder().name(stage.getNextStage().getName()).build());
        this.implementationReturnValue = new ReturnValue("", model.getImplementationType());

        this.implementationMethodTemplate = MethodTemplate.builder()
                .methodSignature(this.getImplementationMethodSignature())
                .method(block -> {
                    block.line("this.%1$s = %2$s;", methodParameter.getName(), methodParameter.getName());
                    block.methodReturn("this");
                })
                .build();
    }

    @Override
    protected String getBaseMethodSignature() {
        return String.format("%1$s(%2$s %3$s)",
                this.name,
                methodParameter.getClientType().toString(),
                methodParameter.getName());    }

    @Override
    public void writeJavadoc(JavaJavadocComment commentBlock) {
        commentBlock.description(description);
        commentBlock.param(methodParameter.getName(), methodParameter.getDescription());
        commentBlock.methodReturns(interfaceReturnValue.getDescription());
    }

    @Override
    public void addImportsTo(Set<String> imports, boolean includeImplementationImports) {
        methodParameter.addImportsTo(imports, false);
    }
}