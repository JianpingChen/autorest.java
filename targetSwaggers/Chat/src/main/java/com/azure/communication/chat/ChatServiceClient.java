// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// Code generated by Microsoft (R) AutoRest Code Generator.

package com.azure.communication.chat;

import com.azure.communication.chat.implementation.ChatsImpl;
import com.azure.communication.chat.models.AddThreadMembersRequest;
import com.azure.communication.chat.models.CreateMessageRequest;
import com.azure.communication.chat.models.CreateMessageResponse;
import com.azure.communication.chat.models.CreateThreadRequest;
import com.azure.communication.chat.models.CreateThreadResponse;
import com.azure.communication.chat.models.GetMessagesResponse;
import com.azure.communication.chat.models.GetThreadsResponse;
import com.azure.communication.chat.models.Message;
import com.azure.communication.chat.models.PostReadReceiptRequest;
import com.azure.communication.chat.models.ReadReceipt;
import com.azure.communication.chat.models.Thread;
import com.azure.communication.chat.models.ThreadMember;
import com.azure.communication.chat.models.UpdateMessageRequest;
import com.azure.communication.chat.models.UpdateThreadRequest;
import com.azure.core.annotation.ReturnType;
import com.azure.core.annotation.ServiceClient;
import com.azure.core.annotation.ServiceMethod;
import com.azure.core.exception.HttpResponseException;
import java.util.List;

/** Initializes a new instance of the synchronous ChatServiceClient type. */
@ServiceClient(builder = ChatServiceClientBuilder.class)
public final class ChatServiceClient {
    private ChatsImpl serviceClient;

    /** Initializes an instance of Chats client. */
    ChatServiceClient(ChatsImpl serviceClient) {
        this.serviceClient = serviceClient;
    }

    /**
     * Gets read receipts for a thread.
     *
     * @param threadId Thread id to get the read receipts for.
     * @param xSkypetoken Skype token header.
     * @param mSCV [Correlation Vector](https://osgwiki.com/wiki/CorrelationVector). If a value is not provided a
     *     randomly generated correlation vector would be returned in the response headers.
     * @throws IllegalArgumentException thrown if parameters fail the validation.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent.
     * @return read receipts for a thread.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public List<ReadReceipt> getReadReceipts(String threadId, String xSkypetoken, String mSCV) {
        return this.serviceClient.getReadReceipts(threadId, xSkypetoken, mSCV);
    }

    /**
     * Posts a Read Receipt Event to a thread, on behalf of a user.
     *
     * @param threadId Id of the thread.
     * @param xSkypetoken Skype token header.
     * @param mSCV [Correlation Vector](https://osgwiki.com/wiki/CorrelationVector). If a value is not provided a
     *     randomly generated correlation vector would be returned in the response headers.
     * @param body Request payload for sending a read receipt.
     * @throws IllegalArgumentException thrown if parameters fail the validation.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public void sendReadReceipt(String threadId, String xSkypetoken, String mSCV, PostReadReceiptRequest body) {
        this.serviceClient.sendReadReceipt(threadId, xSkypetoken, mSCV, body);
    }

    /**
     * Sends a message to a thread identified by {threadId}.
     *
     * @param threadId The thread id to send the message to.
     * @param xSkypetoken Skype token header.
     * @param mSCV [Correlation Vector](https://osgwiki.com/wiki/CorrelationVector). If a value is not provided a
     *     randomly generated correlation vector would be returned in the response headers.
     * @param body Details of the message to create.
     * @throws IllegalArgumentException thrown if parameters fail the validation.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent.
     * @return the response.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public CreateMessageResponse sendMessage(
            String threadId, String xSkypetoken, String mSCV, CreateMessageRequest body) {
        return this.serviceClient.sendMessage(threadId, xSkypetoken, mSCV, body);
    }

    /**
     * Gets a list of message from a thread identified by {threadId}.
     *
     * @param threadId The thread id of the message.
     * @param xSkypetoken Skype token header.
     * @param pageSize The number of messages being requested.
     * @param startTime The start time where the range query. This is represented by number of seconds since epoch time.
     * @param syncState The continuation token that previous request obtained. This is used for paging.
     * @param mSCV [Correlation Vector](https://osgwiki.com/wiki/CorrelationVector). If a value is not provided a
     *     randomly generated correlation vector would be returned in the response headers.
     * @throws IllegalArgumentException thrown if parameters fail the validation.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent.
     * @return a list of message from a thread identified by {threadId}.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public GetMessagesResponse getMessages(
            String threadId, String xSkypetoken, Integer pageSize, Long startTime, String syncState, String mSCV) {
        return this.serviceClient.getMessages(threadId, xSkypetoken, pageSize, startTime, syncState, mSCV);
    }

    /**
     * Gets a message identified by {messageId}.
     *
     * @param threadId The thread id of the message.
     * @param messageId The message id of the message.
     * @param xSkypetoken Skype token header.
     * @param mSCV [Correlation Vector](https://osgwiki.com/wiki/CorrelationVector). If a value is not provided a
     *     randomly generated correlation vector would be returned in the response headers.
     * @throws IllegalArgumentException thrown if parameters fail the validation.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent.
     * @return a message identified by {messageId}.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Message getMessage(String threadId, String messageId, String xSkypetoken, String mSCV) {
        return this.serviceClient.getMessage(threadId, messageId, xSkypetoken, mSCV);
    }

    /**
     * Updates a message identified by {threadId} and {messageId}.
     *
     * @param threadId The thread id of the message.
     * @param messageId The message id of the message.
     * @param xSkypetoken Skype token header.
     * @param mSCV [Correlation Vector](https://osgwiki.com/wiki/CorrelationVector). If a value is not provided a
     *     randomly generated correlation vector would be returned in the response headers.
     * @param body Details of the request to update the message.
     * @throws IllegalArgumentException thrown if parameters fail the validation.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public void updateMessage(
            String threadId, String messageId, String xSkypetoken, String mSCV, UpdateMessageRequest body) {
        this.serviceClient.updateMessage(threadId, messageId, xSkypetoken, mSCV, body);
    }

    /**
     * Deletes a message identified by {threadId} and {messageId}.
     *
     * @param threadId The thread id of the message.
     * @param messageId The message id of the message.
     * @param xSkypetoken Skype token header.
     * @param mSCV [Correlation Vector](https://osgwiki.com/wiki/CorrelationVector). If a value is not provided a
     *     randomly generated correlation vector would be returned in the response headers.
     * @throws IllegalArgumentException thrown if parameters fail the validation.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public void deleteMessage(String threadId, String messageId, String xSkypetoken, String mSCV) {
        this.serviceClient.deleteMessage(threadId, messageId, xSkypetoken, mSCV);
    }

    /**
     * Posts a Typing Event to a thread, on behalf of a user.
     *
     * @param threadId Id of the thread.
     * @param xSkypetoken Skype token header.
     * @param mSCV [Correlation Vector](https://osgwiki.com/wiki/CorrelationVector). If a value is not provided a
     *     randomly generated correlation vector would be returned in the response headers.
     * @throws IllegalArgumentException thrown if parameters fail the validation.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public void notifyUserTyping(String threadId, String xSkypetoken, String mSCV) {
        this.serviceClient.notifyUserTyping(threadId, xSkypetoken, mSCV);
    }

    /**
     * Gets the members of a thread.
     *
     * @param threadId Thread id to get members for.
     * @param xSkypetoken Skype token header.
     * @param mSCV [Correlation Vector](https://osgwiki.com/wiki/CorrelationVector). If a value is not provided a
     *     randomly generated correlation vector would be returned in the response headers.
     * @throws IllegalArgumentException thrown if parameters fail the validation.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent.
     * @return the members of a thread.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public List<ThreadMember> getThreadMembers(String threadId, String xSkypetoken, String mSCV) {
        return this.serviceClient.getThreadMembers(threadId, xSkypetoken, mSCV);
    }

    /**
     * Adds thread members to a thread. If members already exist, no change occurs.
     *
     * @param threadId Id of the thread to add members to.
     * @param xSkypetoken Skype token header.
     * @param mSCV [Correlation Vector](https://osgwiki.com/wiki/CorrelationVector). If a value is not provided a
     *     randomly generated correlation vector would be returned in the response headers.
     * @param body Thread members to be added to the thread.
     * @throws IllegalArgumentException thrown if parameters fail the validation.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public void addThreadMembers(String threadId, String xSkypetoken, String mSCV, AddThreadMembersRequest body) {
        this.serviceClient.addThreadMembers(threadId, xSkypetoken, mSCV, body);
    }

    /**
     * Remove a member from a thread.
     *
     * @param threadId Thread id to remove members from.
     * @param memberId Id of the thread member to remove from the thread.
     * @param xSkypetoken Skype token header.
     * @param mSCV [Correlation Vector](https://osgwiki.com/wiki/CorrelationVector). If a value is not provided a
     *     randomly generated correlation vector would be returned in the response headers.
     * @throws IllegalArgumentException thrown if parameters fail the validation.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public void removeThreadMember(String threadId, String memberId, String xSkypetoken, String mSCV) {
        this.serviceClient.removeThreadMember(threadId, memberId, xSkypetoken, mSCV);
    }

    /**
     * Creates a chat thread.
     *
     * @param xSkypetoken Skype token header.
     * @param mSCV [Correlation Vector](https://osgwiki.com/wiki/CorrelationVector). If a value is not provided a
     *     randomly generated correlation vector would be returned in the response headers.
     * @param body Request payload for creating a chat thread.
     * @throws IllegalArgumentException thrown if parameters fail the validation.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent.
     * @return the response.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public CreateThreadResponse createThread(String xSkypetoken, String mSCV, CreateThreadRequest body) {
        return this.serviceClient.createThread(xSkypetoken, mSCV, body);
    }

    /**
     * Gets a list of threads for a user identified by {userId}.
     *
     * @param xSkypetoken Skype token header.
     * @param pageSize The number of threads being requested.
     * @param startTime The start time where the range query. This is represented by number of seconds since epoch time.
     * @param syncState The continuation token that previous request obtained. This is used for paging.
     * @param mSCV [Correlation Vector](https://osgwiki.com/wiki/CorrelationVector). If a value is not provided a
     *     randomly generated correlation vector would be returned in the response headers.
     * @throws IllegalArgumentException thrown if parameters fail the validation.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent.
     * @return a list of threads for a user identified by {userId}.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public GetThreadsResponse getThreads(
            String xSkypetoken, Integer pageSize, Long startTime, String syncState, String mSCV) {
        return this.serviceClient.getThreads(xSkypetoken, pageSize, startTime, syncState, mSCV);
    }

    /**
     * Updates a thread's properties.
     *
     * @param threadId The id of the thread to edit.
     * @param xSkypetoken Skype token header.
     * @param mSCV [Correlation Vector](https://osgwiki.com/wiki/CorrelationVector). If a value is not provided a
     *     randomly generated correlation vector would be returned in the response headers.
     * @param body Request payload for updating a chat thread.
     * @throws IllegalArgumentException thrown if parameters fail the validation.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public void updateThread(String threadId, String xSkypetoken, String mSCV, UpdateThreadRequest body) {
        this.serviceClient.updateThread(threadId, xSkypetoken, mSCV, body);
    }

    /**
     * Gets a chat thread.
     *
     * @param threadId Thread id to get.
     * @param xSkypetoken Skype token header.
     * @param mSCV [Correlation Vector](https://osgwiki.com/wiki/CorrelationVector). If a value is not provided a
     *     randomly generated correlation vector would be returned in the response headers.
     * @throws IllegalArgumentException thrown if parameters fail the validation.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent.
     * @return a chat thread.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Thread getThread(String threadId, String xSkypetoken, String mSCV) {
        return this.serviceClient.getThread(threadId, xSkypetoken, mSCV);
    }

    /**
     * Deletes a thread.
     *
     * @param threadId Thread id to delete.
     * @param xSkypetoken Skype token header.
     * @param mSCV [Correlation Vector](https://osgwiki.com/wiki/CorrelationVector). If a value is not provided a
     *     randomly generated correlation vector would be returned in the response headers.
     * @throws IllegalArgumentException thrown if parameters fail the validation.
     * @throws HttpResponseException thrown if the request is rejected by server.
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public void deleteThread(String threadId, String xSkypetoken, String mSCV) {
        this.serviceClient.deleteThread(threadId, xSkypetoken, mSCV);
    }
}