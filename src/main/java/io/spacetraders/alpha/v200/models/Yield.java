/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package io.spacetraders.alpha.v200.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for Yield type.
 */
public class Yield {
    private String tradeSymbol;
    private int units;

    /**
     * Default constructor.
     */
    public Yield() {
    }

    /**
     * Initialization constructor.
     * @param  tradeSymbol  String value for tradeSymbol.
     * @param  units  int value for units.
     */
    public Yield(
            String tradeSymbol,
            int units) {
        this.tradeSymbol = tradeSymbol;
        this.units = units;
    }

    /**
     * Getter for TradeSymbol.
     * @return Returns the String
     */
    @JsonGetter("tradeSymbol")
    public String getTradeSymbol() {
        return tradeSymbol;
    }

    /**
     * Setter for TradeSymbol.
     * @param tradeSymbol Value for String
     */
    @JsonSetter("tradeSymbol")
    public void setTradeSymbol(String tradeSymbol) {
        this.tradeSymbol = tradeSymbol;
    }

    /**
     * Getter for Units.
     * @return Returns the int
     */
    @JsonGetter("units")
    public int getUnits() {
        return units;
    }

    /**
     * Setter for Units.
     * @param units Value for int
     */
    @JsonSetter("units")
    public void setUnits(int units) {
        this.units = units;
    }

    /**
     * Converts this Yield into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "Yield [" + "tradeSymbol=" + tradeSymbol + ", units=" + units + "]";
    }

    /**
     * Builds a new {@link Yield.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link Yield.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(tradeSymbol, units);
        return builder;
    }

    /**
     * Class to build instances of {@link Yield}.
     */
    public static class Builder {
        private String tradeSymbol;
        private int units;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  tradeSymbol  String value for tradeSymbol.
         * @param  units  int value for units.
         */
        public Builder(String tradeSymbol, int units) {
            this.tradeSymbol = tradeSymbol;
            this.units = units;
        }

        /**
         * Setter for tradeSymbol.
         * @param  tradeSymbol  String value for tradeSymbol.
         * @return Builder
         */
        public Builder tradeSymbol(String tradeSymbol) {
            this.tradeSymbol = tradeSymbol;
            return this;
        }

        /**
         * Setter for units.
         * @param  units  int value for units.
         * @return Builder
         */
        public Builder units(int units) {
            this.units = units;
            return this;
        }

        /**
         * Builds a new {@link Yield} object using the set fields.
         * @return {@link Yield}
         */
        public Yield build() {
            return new Yield(tradeSymbol, units);
        }
    }
}