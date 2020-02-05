// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

package fixtures.validation.models;

import com.azure.core.implementation.annotation.Fluent;
import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * The product documentation.
 */
@Fluent
public final class ChildProduct {
    /*
     * Constant string
     */
    @JsonProperty(value = "constProperty", required = true)
    private String constProperty;

    /*
     * Count
     */
    @JsonProperty(value = "count")
    private Integer count;

    /**
     * Creates an instance of ChildProduct class.
     */
    public ChildProduct() {
        constProperty = "constant";
    }

    /**
     * Get the constProperty property: Constant string.
     *
     * @return the constProperty value.
     */
    public String constProperty() {
        return this.constProperty;
    }

    /**
     * Set the constProperty property: Constant string.
     *
     * @param constProperty the constProperty value to set.
     * @return the ChildProduct object itself.
     */
    public ChildProduct constProperty(String constProperty) {
        this.constProperty = constProperty;
        return this;
    }

    /**
     * Get the count property: Count.
     *
     * @return the count value.
     */
    public Integer count() {
        return this.count;
    }

    /**
     * Set the count property: Count.
     *
     * @param count the count value to set.
     * @return the ChildProduct object itself.
     */
    public ChildProduct count(Integer count) {
        this.count = count;
        return this;
    }
}