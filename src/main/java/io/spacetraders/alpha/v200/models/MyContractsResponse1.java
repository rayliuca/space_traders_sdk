/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package io.spacetraders.alpha.v200.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for MyContractsResponse1 type.
 */
public class MyContractsResponse1 {
    private Contract data;

    /**
     * Default constructor.
     */
    public MyContractsResponse1() {
    }

    /**
     * Initialization constructor.
     * @param  data  Contract value for data.
     */
    public MyContractsResponse1(
            Contract data) {
        this.data = data;
    }

    /**
     * Getter for Data.
     * @return Returns the Contract
     */
    @JsonGetter("data")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Contract getData() {
        return data;
    }

    /**
     * Setter for Data.
     * @param data Value for Contract
     */
    @JsonSetter("data")
    public void setData(Contract data) {
        this.data = data;
    }

    /**
     * Converts this MyContractsResponse1 into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "MyContractsResponse1 [" + "data=" + data + "]";
    }

    /**
     * Builds a new {@link MyContractsResponse1.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link MyContractsResponse1.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .data(getData());
        return builder;
    }

    /**
     * Class to build instances of {@link MyContractsResponse1}.
     */
    public static class Builder {
        private Contract data;



        /**
         * Setter for data.
         * @param  data  Contract value for data.
         * @return Builder
         */
        public Builder data(Contract data) {
            this.data = data;
            return this;
        }

        /**
         * Builds a new {@link MyContractsResponse1} object using the set fields.
         * @return {@link MyContractsResponse1}
         */
        public MyContractsResponse1 build() {
            return new MyContractsResponse1(data);
        }
    }
}
