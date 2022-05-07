/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package io.spacetraders.alpha.v200.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for MyShipsResponse type.
 */
public class MyShipsResponse {
    private Ship data;

    /**
     * Default constructor.
     */
    public MyShipsResponse() {
    }

    /**
     * Initialization constructor.
     * @param  data  Ship value for data.
     */
    public MyShipsResponse(
            Ship data) {
        this.data = data;
    }

    /**
     * Getter for Data.
     * @return Returns the Ship
     */
    @JsonGetter("data")
    public Ship getData() {
        return data;
    }

    /**
     * Setter for Data.
     * @param data Value for Ship
     */
    @JsonSetter("data")
    public void setData(Ship data) {
        this.data = data;
    }

    /**
     * Converts this MyShipsResponse into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "MyShipsResponse [" + "data=" + data + "]";
    }

    /**
     * Builds a new {@link MyShipsResponse.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link MyShipsResponse.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(data);
        return builder;
    }

    /**
     * Class to build instances of {@link MyShipsResponse}.
     */
    public static class Builder {
        private Ship data;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  data  Ship value for data.
         */
        public Builder(Ship data) {
            this.data = data;
        }

        /**
         * Setter for data.
         * @param  data  Ship value for data.
         * @return Builder
         */
        public Builder data(Ship data) {
            this.data = data;
            return this;
        }

        /**
         * Builds a new {@link MyShipsResponse} object using the set fields.
         * @return {@link MyShipsResponse}
         */
        public MyShipsResponse build() {
            return new MyShipsResponse(data);
        }
    }
}