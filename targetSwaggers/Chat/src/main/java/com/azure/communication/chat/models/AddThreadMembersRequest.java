// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// Code generated by Microsoft (R) AutoRest Code Generator.

package com.azure.communication.chat.models;

import com.azure.core.annotation.Fluent;
import com.fasterxml.jackson.annotation.JsonProperty;
import java.util.List;

/** The AddThreadMembersRequest model. */
@Fluent
public final class AddThreadMembersRequest {
    /*
     * Members to add to a thread
     */
    @JsonProperty(value = "members", required = true)
    private List<ThreadMember> members;

    /**
     * Get the members property: Members to add to a thread.
     *
     * @return the members value.
     */
    public List<ThreadMember> getMembers() {
        return this.members;
    }

    /**
     * Set the members property: Members to add to a thread.
     *
     * @param members the members value to set.
     * @return the AddThreadMembersRequest object itself.
     */
    public AddThreadMembersRequest setMembers(List<ThreadMember> members) {
        this.members = members;
        return this;
    }
}
