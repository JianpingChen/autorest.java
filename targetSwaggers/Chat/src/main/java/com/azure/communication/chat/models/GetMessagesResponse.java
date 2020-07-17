// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// Code generated by Microsoft (R) AutoRest Code Generator.

package com.azure.communication.chat.models;

import com.azure.core.annotation.Fluent;
import com.fasterxml.jackson.annotation.JsonProperty;
import java.util.List;

/** The GetMessagesResponse model. */
@Fluent
public final class GetMessagesResponse {
    /*
     * List of messages.
     */
    @JsonProperty(value = "messages")
    private List<Message> messages;

    /*
     * Continuation link to get new and edited messages
     */
    @JsonProperty(value = "syncState")
    private String syncState;

    /*
     * If there are more messages that can be retrieved, the backward link will
     * be populated.
     */
    @JsonProperty(value = "backwardLink")
    private String backwardLink;

    /**
     * Get the messages property: List of messages.
     *
     * @return the messages value.
     */
    public List<Message> getMessages() {
        return this.messages;
    }

    /**
     * Set the messages property: List of messages.
     *
     * @param messages the messages value to set.
     * @return the GetMessagesResponse object itself.
     */
    public GetMessagesResponse setMessages(List<Message> messages) {
        this.messages = messages;
        return this;
    }

    /**
     * Get the syncState property: Continuation link to get new and edited messages.
     *
     * @return the syncState value.
     */
    public String getSyncState() {
        return this.syncState;
    }

    /**
     * Set the syncState property: Continuation link to get new and edited messages.
     *
     * @param syncState the syncState value to set.
     * @return the GetMessagesResponse object itself.
     */
    public GetMessagesResponse setSyncState(String syncState) {
        this.syncState = syncState;
        return this;
    }

    /**
     * Get the backwardLink property: If there are more messages that can be retrieved, the backward link will be
     * populated.
     *
     * @return the backwardLink value.
     */
    public String getBackwardLink() {
        return this.backwardLink;
    }

    /**
     * Set the backwardLink property: If there are more messages that can be retrieved, the backward link will be
     * populated.
     *
     * @param backwardLink the backwardLink value to set.
     * @return the GetMessagesResponse object itself.
     */
    public GetMessagesResponse setBackwardLink(String backwardLink) {
        this.backwardLink = backwardLink;
        return this;
    }
}
