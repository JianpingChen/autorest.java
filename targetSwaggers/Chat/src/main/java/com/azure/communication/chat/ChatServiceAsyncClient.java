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
import com.azure.core.http.rest.Response;
import java.util.List;
import reactor.core.publisher.Mono;

/** Initializes a new instance of the asynchronous ChatServiceClient type. */
@ServiceClient(builder = ChatServiceClientBuilder.class, isAsync = true)
public final class ChatServiceAsyncClient {
    private ChatsImpl serviceClient;

    /** Initializes an instance of Chats client. */
    ChatServiceAsyncClient(ChatsImpl serviceClient) {
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
    public Mono<Response<List<ReadReceipt>>> getReadReceiptsWithResponse(
            String threadId, String xSkypetoken, String mSCV) {
        return this.serviceClient.getReadReceiptsWithResponseAsync(threadId, xSkypetoken, mSCV);
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
    public Mono<List<ReadReceipt>> getReadReceipts(String threadId, String xSkypetoken, String mSCV) {
        return this.serviceClient.getReadReceiptsAsync(threadId, xSkypetoken, mSCV);
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
     * @return the completion.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Mono<Response<Void>> sendReadReceiptWithResponse(
            String threadId, String xSkypetoken, String mSCV, PostReadReceiptRequest body) {
        return this.serviceClient.sendReadReceiptWithResponseAsync(threadId, xSkypetoken, mSCV, body);
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
     * @return the completion.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Mono<Void> sendReadReceipt(String threadId, String xSkypetoken, String mSCV, PostReadReceiptRequest body) {
        return this.serviceClient.sendReadReceiptAsync(threadId, xSkypetoken, mSCV, body);
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
    public Mono<Response<CreateMessageResponse>> sendMessageWithResponse(
            String threadId, String xSkypetoken, String mSCV, CreateMessageRequest body) {
        return this.serviceClient.sendMessageWithResponseAsync(threadId, xSkypetoken, mSCV, body);
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
    public Mono<CreateMessageResponse> sendMessage(
            String threadId, String xSkypetoken, String mSCV, CreateMessageRequest body) {
        return this.serviceClient.sendMessageAsync(threadId, xSkypetoken, mSCV, body);
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
    public Mono<Response<GetMessagesResponse>> getMessagesWithResponse(
            String threadId, String xSkypetoken, Integer pageSize, Long startTime, String syncState, String mSCV) {
        return this.serviceClient.getMessagesWithResponseAsync(
                threadId, xSkypetoken, pageSize, startTime, syncState, mSCV);
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
    public Mono<GetMessagesResponse> getMessages(
            String threadId, String xSkypetoken, Integer pageSize, Long startTime, String syncState, String mSCV) {
        return this.serviceClient.getMessagesAsync(threadId, xSkypetoken, pageSize, startTime, syncState, mSCV);
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
    public Mono<Response<Message>> getMessageWithResponse(
            String threadId, String messageId, String xSkypetoken, String mSCV) {
        return this.serviceClient.getMessageWithResponseAsync(threadId, messageId, xSkypetoken, mSCV);
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
    public Mono<Message> getMessage(String threadId, String messageId, String xSkypetoken, String mSCV) {
        return this.serviceClient.getMessageAsync(threadId, messageId, xSkypetoken, mSCV);
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
     * @return the completion.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Mono<Response<Void>> updateMessageWithResponse(
            String threadId, String messageId, String xSkypetoken, String mSCV, UpdateMessageRequest body) {
        return this.serviceClient.updateMessageWithResponseAsync(threadId, messageId, xSkypetoken, mSCV, body);
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
     * @return the completion.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Mono<Void> updateMessage(
            String threadId, String messageId, String xSkypetoken, String mSCV, UpdateMessageRequest body) {
        return this.serviceClient.updateMessageAsync(threadId, messageId, xSkypetoken, mSCV, body);
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
     * @return the completion.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Mono<Response<Void>> deleteMessageWithResponse(
            String threadId, String messageId, String xSkypetoken, String mSCV) {
        return this.serviceClient.deleteMessageWithResponseAsync(threadId, messageId, xSkypetoken, mSCV);
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
     * @return the completion.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Mono<Void> deleteMessage(String threadId, String messageId, String xSkypetoken, String mSCV) {
        return this.serviceClient.deleteMessageAsync(threadId, messageId, xSkypetoken, mSCV);
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
     * @return the completion.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Mono<Response<Void>> notifyUserTypingWithResponse(String threadId, String xSkypetoken, String mSCV) {
        return this.serviceClient.notifyUserTypingWithResponseAsync(threadId, xSkypetoken, mSCV);
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
     * @return the completion.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Mono<Void> notifyUserTyping(String threadId, String xSkypetoken, String mSCV) {
        return this.serviceClient.notifyUserTypingAsync(threadId, xSkypetoken, mSCV);
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
    public Mono<Response<List<ThreadMember>>> getThreadMembersWithResponse(
            String threadId, String xSkypetoken, String mSCV) {
        return this.serviceClient.getThreadMembersWithResponseAsync(threadId, xSkypetoken, mSCV);
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
    public Mono<List<ThreadMember>> getThreadMembers(String threadId, String xSkypetoken, String mSCV) {
        return this.serviceClient.getThreadMembersAsync(threadId, xSkypetoken, mSCV);
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
     * @return the completion.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Mono<Response<Void>> addThreadMembersWithResponse(
            String threadId, String xSkypetoken, String mSCV, AddThreadMembersRequest body) {
        return this.serviceClient.addThreadMembersWithResponseAsync(threadId, xSkypetoken, mSCV, body);
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
     * @return the completion.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Mono<Void> addThreadMembers(String threadId, String xSkypetoken, String mSCV, AddThreadMembersRequest body) {
        return this.serviceClient.addThreadMembersAsync(threadId, xSkypetoken, mSCV, body);
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
     * @return the completion.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Mono<Response<Void>> removeThreadMemberWithResponse(
            String threadId, String memberId, String xSkypetoken, String mSCV) {
        return this.serviceClient.removeThreadMemberWithResponseAsync(threadId, memberId, xSkypetoken, mSCV);
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
     * @return the completion.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Mono<Void> removeThreadMember(String threadId, String memberId, String xSkypetoken, String mSCV) {
        return this.serviceClient.removeThreadMemberAsync(threadId, memberId, xSkypetoken, mSCV);
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
    public Mono<Response<CreateThreadResponse>> createThreadWithResponse(
            String xSkypetoken, String mSCV, CreateThreadRequest body) {
        return this.serviceClient.createThreadWithResponseAsync(xSkypetoken, mSCV, body);
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
    public Mono<CreateThreadResponse> createThread(String xSkypetoken, String mSCV, CreateThreadRequest body) {
        return this.serviceClient.createThreadAsync(xSkypetoken, mSCV, body);
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
    public Mono<Response<GetThreadsResponse>> getThreadsWithResponse(
            String xSkypetoken, Integer pageSize, Long startTime, String syncState, String mSCV) {
        return this.serviceClient.getThreadsWithResponseAsync(xSkypetoken, pageSize, startTime, syncState, mSCV);
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
    public Mono<GetThreadsResponse> getThreads(
            String xSkypetoken, Integer pageSize, Long startTime, String syncState, String mSCV) {
        return this.serviceClient.getThreadsAsync(xSkypetoken, pageSize, startTime, syncState, mSCV);
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
     * @return the completion.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Mono<Response<Void>> updateThreadWithResponse(
            String threadId, String xSkypetoken, String mSCV, UpdateThreadRequest body) {
        return this.serviceClient.updateThreadWithResponseAsync(threadId, xSkypetoken, mSCV, body);
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
     * @return the completion.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Mono<Void> updateThread(String threadId, String xSkypetoken, String mSCV, UpdateThreadRequest body) {
        return this.serviceClient.updateThreadAsync(threadId, xSkypetoken, mSCV, body);
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
    public Mono<Response<Thread>> getThreadWithResponse(String threadId, String xSkypetoken, String mSCV) {
        return this.serviceClient.getThreadWithResponseAsync(threadId, xSkypetoken, mSCV);
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
    public Mono<Thread> getThread(String threadId, String xSkypetoken, String mSCV) {
        return this.serviceClient.getThreadAsync(threadId, xSkypetoken, mSCV);
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
     * @return the completion.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Mono<Response<Void>> deleteThreadWithResponse(String threadId, String xSkypetoken, String mSCV) {
        return this.serviceClient.deleteThreadWithResponseAsync(threadId, xSkypetoken, mSCV);
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
     * @return the completion.
     */
    @ServiceMethod(returns = ReturnType.SINGLE)
    public Mono<Void> deleteThread(String threadId, String xSkypetoken, String mSCV) {
        return this.serviceClient.deleteThreadAsync(threadId, xSkypetoken, mSCV);
    }
}