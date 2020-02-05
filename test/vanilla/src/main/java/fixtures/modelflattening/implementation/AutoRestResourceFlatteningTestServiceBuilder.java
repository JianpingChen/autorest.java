// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

package fixtures.modelflattening.implementation;

import com.azure.core.http.HttpPipeline;
import com.azure.core.http.rest.SimpleResponse;
import com.azure.core.http.rest.VoidResponse;
import com.azure.core.implementation.RestProxy;
import com.azure.core.implementation.Validator;
import com.azure.core.implementation.annotation.BodyParam;
import com.azure.core.implementation.annotation.ExpectedResponses;
import com.azure.core.implementation.annotation.Get;
import com.azure.core.implementation.annotation.Host;
import com.azure.core.implementation.annotation.PathParam;
import com.azure.core.implementation.annotation.Post;
import com.azure.core.implementation.annotation.Put;
import com.azure.core.implementation.annotation.ReturnType;
import com.azure.core.implementation.annotation.ServiceClientBuilder;
import com.azure.core.implementation.annotation.ServiceInterface;
import com.azure.core.implementation.annotation.ServiceMethod;
import com.azure.core.implementation.annotation.UnexpectedResponseExceptionType;
import fixtures.modelflattening.AutoRestResourceFlatteningTestService;
import fixtures.modelflattening.models.ErrorException;
import fixtures.modelflattening.models.FlattenedProduct;
import fixtures.modelflattening.models.FlattenParameterGroup;
import fixtures.modelflattening.models.ProductWrapper;
import fixtures.modelflattening.models.Resource;
import fixtures.modelflattening.models.ResourceCollection;
import fixtures.modelflattening.models.SimpleProduct;
import fixtures.modelflattening.models.WrappedProduct;
import java.util.List;
import java.util.Map;
import reactor.core.publisher.Mono;

/**
 * A builder for creating a new instance of the AutoRestResourceFlatteningTestService type.
 */
@ServiceClientBuilder(serviceClients = AutoRestResourceFlatteningTestService.class)
public final class AutoRestResourceFlatteningTestServiceBuilder {
    /*
     * The HTTP pipeline to send requests through
     */
    private HttpPipeline pipeline;

    /**
     * Sets The HTTP pipeline to send requests through.
     *
     * @param pipeline the pipeline value.
     * @return the AutoRestResourceFlatteningTestServiceBuilder.
     */
    public AutoRestResourceFlatteningTestServiceBuilder pipeline(HttpPipeline pipeline) {
        this.pipeline = pipeline;
        return this;
    }

    /**
     * Builds an instance of AutoRestResourceFlatteningTestService with the provided parameters.
     *
     * @return an instance of AutoRestResourceFlatteningTestService.
     */
    public AutoRestResourceFlatteningTestService build() {
        if (pipeline == null) {
            this.pipeline = RestProxy.createDefaultPipeline();
        }
        AutoRestResourceFlatteningTestServiceImpl client = new AutoRestResourceFlatteningTestServiceImpl(pipeline);
        return client;
    }
}