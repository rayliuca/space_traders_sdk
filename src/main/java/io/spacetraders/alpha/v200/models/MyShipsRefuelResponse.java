/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package io.spacetraders.alpha.v200.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for MyShipsRefuelResponse type.
 */
public class MyShipsRefuelResponse {
    private Data12 data;

    /**
     * Default constructor.
     */
    public MyShipsRefuelResponse() {
    }

    /**
     * Initialization constructor.
     * @param  data  Data12 value for data.
     */
    public MyShipsRefuelResponse(
            Data12 data) {
        this.data = data;
    }

    /**
     * Getter for Data.
     * @return Returns the Data12
     */
    @JsonGetter("data")
    public Data12 getData() {
        return data;
    }

    /**
     * Setter for Data.
     * @param data Value for Data12
     */
    @JsonSetter("data")
    public void setData(Data12 data) {
        this.data = data;
    }

    /**
     * Converts this MyShipsRefuelResponse into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "MyShipsRefuelResponse [" + "data=" + data + "]";
    }

    /**
     * Builds a new {@link MyShipsRefuelResponse.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link MyShipsRefuelResponse.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(data);
        return builder;
    }

    /**
     * Class to build instances of {@link MyShipsRefuelResponse}.
     */
    public static class Builder {
        private Data12 data;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  data  Data12 value for data.
         */
        public Builder(Data12 data) {
            this.data = data;
        }

        /**
         * Setter for data.
         * @param  data  Data12 value for data.
         * @return Builder
         */
        public Builder data(Data12 data) {
            this.data = data;
            return this;
        }

        /**
         * Builds a new {@link MyShipsRefuelResponse} object using the set fields.
         * @return {@link MyShipsRefuelResponse}
         */
        public MyShipsRefuelResponse build() {
            return new MyShipsRefuelResponse(data);
        }
    }
}
