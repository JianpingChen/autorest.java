// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// Code generated by Microsoft (R) AutoRest Code Generator.

package com.azure.communication.chat.models;

import com.azure.core.annotation.Fluent;
import com.fasterxml.jackson.annotation.JsonProperty;

/** The PostReadReceiptRequest model. */
@Fluent
public final class PostReadReceiptRequest {
    /*
     * The client message Id specified when the message was sent.
     * This Id is a client-specific Id in a numeric unsigned Int64 format. It
     * can be used for client deduping, among other client usages.
     */
    @JsonProperty(value = "clientMessageId", required = true)
    private String clientMessageId;

    /*
     * Id of the latest message read by current user
     */
    @JsonProperty(value = "messageId", required = true)
    private String messageId;

    /**
     * Get the clientMessageId property: The client message Id specified when the message was sent. This Id is a
     * client-specific Id in a numeric unsigned Int64 format. It can be used for client deduping, among other client
     * usages.
     *
     * @return the clientMessageId value.
     */
    public String getClientMessageId() {
        return this.clientMessageId;
    }

    /**
     * Set the clientMessageId property: The client message Id specified when the message was sent. This Id is a
     * client-specific Id in a numeric unsigned Int64 format. It can be used for client deduping, among other client
     * usages.
     *
     * @param clientMessageId the clientMessageId value to set.
     * @return the PostReadReceiptRequest object itself.
     */
    public PostReadReceiptRequest setClientMessageId(String clientMessageId) {
        this.clientMessageId = clientMessageId;
        return this;
    }

    /**
     * Get the messageId property: Id of the latest message read by current user.
     *
     * @return the messageId value.
     */
    public String getMessageId() {
        return this.messageId;
    }

    /**
     * Set the messageId property: Id of the latest message read by current user.
     *
     * @param messageId the messageId value to set.
     * @return the PostReadReceiptRequest object itself.
     */
    public PostReadReceiptRequest setMessageId(String messageId) {
        this.messageId = messageId;
        return this;
    }
}