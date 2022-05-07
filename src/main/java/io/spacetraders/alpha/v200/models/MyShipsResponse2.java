/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package io.spacetraders.alpha.v200.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for MyShipsResponse2 type.
 */
public class MyShipsResponse2 {
    private Data17 data;

    /**
     * Default constructor.
     */
    public MyShipsResponse2() {
    }

    /**
     * Initialization constructor.
     * @param  data  Data17 value for data.
     */
    public MyShipsResponse2(
            Data17 data) {
        this.data = data;
    }

    /**
     * Getter for Data.
     * @return Returns the Data17
     */
    @JsonGetter("data")
    public Data17 getData() {
        return data;
    }

    /**
     * Setter for Data.
     * @param data Value for Data17
     */
    @JsonSetter("data")
    public void setData(Data17 data) {
        this.data = data;
    }

    /**
     * Converts this MyShipsResponse2 into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "MyShipsResponse2 [" + "data=" + data + "]";
    }

    /**
     * Builds a new {@link MyShipsResponse2.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link MyShipsResponse2.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(data);
        return builder;
    }

    /**
     * Class to build instances of {@link MyShipsResponse2}.
     */
    public static class Builder {
        private Data17 data;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  data  Data17 value for data.
         */
        public Builder(Data17 data) {
            this.data = data;
        }

        /**
         * Setter for data.
         * @param  data  Data17 value for data.
         * @return Builder
         */
        public Builder data(Data17 data) {
            this.data = data;
            return this;
        }

        /**
         * Builds a new {@link MyShipsResponse2} object using the set fields.
         * @return {@link MyShipsResponse2}
         */
        public MyShipsResponse2 build() {
            return new MyShipsResponse2(data);
        }
    }
}