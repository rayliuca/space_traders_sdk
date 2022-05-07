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
 * This is a model class for MyShipsScanResponse1 type.
 */
public class MyShipsScanResponse1 {
    private Data9 data;

    /**
     * Default constructor.
     */
    public MyShipsScanResponse1() {
    }

    /**
     * Initialization constructor.
     * @param  data  Data9 value for data.
     */
    public MyShipsScanResponse1(
            Data9 data) {
        this.data = data;
    }

    /**
     * Getter for Data.
     * @return Returns the Data9
     */
    @JsonGetter("data")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Data9 getData() {
        return data;
    }

    /**
     * Setter for Data.
     * @param data Value for Data9
     */
    @JsonSetter("data")
    public void setData(Data9 data) {
        this.data = data;
    }

    /**
     * Converts this MyShipsScanResponse1 into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "MyShipsScanResponse1 [" + "data=" + data + "]";
    }

    /**
     * Builds a new {@link MyShipsScanResponse1.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link MyShipsScanResponse1.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .data(getData());
        return builder;
    }

    /**
     * Class to build instances of {@link MyShipsScanResponse1}.
     */
    public static class Builder {
        private Data9 data;



        /**
         * Setter for data.
         * @param  data  Data9 value for data.
         * @return Builder
         */
        public Builder data(Data9 data) {
            this.data = data;
            return this;
        }

        /**
         * Builds a new {@link MyShipsScanResponse1} object using the set fields.
         * @return {@link MyShipsScanResponse1}
         */
        public MyShipsScanResponse1 build() {
            return new MyShipsScanResponse1(data);
        }
    }
}
