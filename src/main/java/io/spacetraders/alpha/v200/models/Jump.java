/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package io.spacetraders.alpha.v200.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for Jump type.
 */
public class Jump {
    private String shipSymbol;
    private String destination;

    /**
     * Default constructor.
     */
    public Jump() {
    }

    /**
     * Initialization constructor.
     * @param  shipSymbol  String value for shipSymbol.
     * @param  destination  String value for destination.
     */
    public Jump(
            String shipSymbol,
            String destination) {
        this.shipSymbol = shipSymbol;
        this.destination = destination;
    }

    /**
     * Getter for ShipSymbol.
     * @return Returns the String
     */
    @JsonGetter("shipSymbol")
    public String getShipSymbol() {
        return shipSymbol;
    }

    /**
     * Setter for ShipSymbol.
     * @param shipSymbol Value for String
     */
    @JsonSetter("shipSymbol")
    public void setShipSymbol(String shipSymbol) {
        this.shipSymbol = shipSymbol;
    }

    /**
     * Getter for Destination.
     * @return Returns the String
     */
    @JsonGetter("destination")
    public String getDestination() {
        return destination;
    }

    /**
     * Setter for Destination.
     * @param destination Value for String
     */
    @JsonSetter("destination")
    public void setDestination(String destination) {
        this.destination = destination;
    }

    /**
     * Converts this Jump into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "Jump [" + "shipSymbol=" + shipSymbol + ", destination=" + destination + "]";
    }

    /**
     * Builds a new {@link Jump.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link Jump.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(shipSymbol, destination);
        return builder;
    }

    /**
     * Class to build instances of {@link Jump}.
     */
    public static class Builder {
        private String shipSymbol;
        private String destination;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  shipSymbol  String value for shipSymbol.
         * @param  destination  String value for destination.
         */
        public Builder(String shipSymbol, String destination) {
            this.shipSymbol = shipSymbol;
            this.destination = destination;
        }

        /**
         * Setter for shipSymbol.
         * @param  shipSymbol  String value for shipSymbol.
         * @return Builder
         */
        public Builder shipSymbol(String shipSymbol) {
            this.shipSymbol = shipSymbol;
            return this;
        }

        /**
         * Setter for destination.
         * @param  destination  String value for destination.
         * @return Builder
         */
        public Builder destination(String destination) {
            this.destination = destination;
            return this;
        }

        /**
         * Builds a new {@link Jump} object using the set fields.
         * @return {@link Jump}
         */
        public Jump build() {
            return new Jump(shipSymbol, destination);
        }
    }
}
