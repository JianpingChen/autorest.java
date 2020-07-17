// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// Code generated by Microsoft (R) AutoRest Code Generator.

package com.azure.communication.chat;

import com.azure.communication.chat.implementation.ChatServiceClientImpl;
import com.azure.core.annotation.ServiceClientBuilder;
import com.azure.core.http.HttpPipeline;
import com.azure.core.http.HttpPipelineBuilder;
import com.azure.core.http.policy.CookiePolicy;
import com.azure.core.http.policy.RetryPolicy;
import com.azure.core.http.policy.UserAgentPolicy;

/** A builder for creating a new instance of the ChatServiceClient type. */
@ServiceClientBuilder(serviceClients = {ChatServiceAsyncClient.class, ChatServiceClient.class})
public final class ChatServiceClientBuilder {
    /*
     * server parameter
     */
    private String host;

    /**
     * Sets server parameter.
     *
     * @param host the host value.
     * @return the ChatServiceClientBuilder.
     */
    public ChatServiceClientBuilder host(String host) {
        this.host = host;
        return this;
    }

    /*
     * The HTTP pipeline to send requests through
     */
    private HttpPipeline pipeline;

    /**
     * Sets The HTTP pipeline to send requests through.
     *
     * @param pipeline the pipeline value.
     * @return the ChatServiceClientBuilder.
     */
    public ChatServiceClientBuilder pipeline(HttpPipeline pipeline) {
        this.pipeline = pipeline;
        return this;
    }

    /**
     * Builds an instance of ChatServiceClientImpl with the provided parameters.
     *
     * @return an instance of ChatServiceClientImpl.
     */
    private ChatServiceClientImpl buildInnerClient() {
        if (host == null) {
            this.host = "";
        }
        if (pipeline == null) {
            this.pipeline =
                    new HttpPipelineBuilder()
                            .policies(new UserAgentPolicy(), new RetryPolicy(), new CookiePolicy())
                            .build();
        }
        ChatServiceClientImpl client = new ChatServiceClientImpl(pipeline, host);
        return client;
    }

    /**
     * Builds an instance of ChatServiceAsyncClient async client.
     *
     * @return an instance of ChatServiceAsyncClient.
     */
    public ChatServiceAsyncClient buildAsyncClient() {
        return new ChatServiceAsyncClient(buildInnerClient().getChats());
    }

    /**
     * Builds an instance of ChatServiceClient sync client.
     *
     * @return an instance of ChatServiceClient.
     */
    public ChatServiceClient buildClient() {
        return new ChatServiceClient(buildInnerClient().getChats());
    }
}