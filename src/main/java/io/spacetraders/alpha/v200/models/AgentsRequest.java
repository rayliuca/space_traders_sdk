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
 * This is a model class for AgentsRequest type.
 */
public class AgentsRequest {
    private String symbol;
    private String faction;

    /**
     * Default constructor.
     */
    public AgentsRequest() {
        faction = "COMMERCE_REPUBLIC";
    }

    /**
     * Initialization constructor.
     * @param  symbol  String value for symbol.
     * @param  faction  String value for faction.
     */
    public AgentsRequest(
            String symbol,
            String faction) {
        this.symbol = symbol;
        this.faction = faction;
    }

    /**
     * Getter for Symbol.
     * How other agents will see your ships and information.
     * @return Returns the String
     */
    @JsonGetter("symbol")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getSymbol() {
        return symbol;
    }

    /**
     * Setter for Symbol.
     * How other agents will see your ships and information.
     * @param symbol Value for String
     */
    @JsonSetter("symbol")
    public void setSymbol(String symbol) {
        this.symbol = symbol;
    }

    /**
     * Getter for Faction.
     * The faction you choose determines your headquarters.
     * @return Returns the String
     */
    @JsonGetter("faction")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getFaction() {
        return faction;
    }

    /**
     * Setter for Faction.
     * The faction you choose determines your headquarters.
     * @param faction Value for String
     */
    @JsonSetter("faction")
    public void setFaction(String faction) {
        this.faction = faction;
    }

    /**
     * Converts this AgentsRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "AgentsRequest [" + "symbol=" + symbol + ", faction=" + faction + "]";
    }

    /**
     * Builds a new {@link AgentsRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link AgentsRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .symbol(getSymbol())
                .faction(getFaction());
        return builder;
    }

    /**
     * Class to build instances of {@link AgentsRequest}.
     */
    public static class Builder {
        private String symbol;
        private String faction = "COMMERCE_REPUBLIC";



        /**
         * Setter for symbol.
         * @param  symbol  String value for symbol.
         * @return Builder
         */
        public Builder symbol(String symbol) {
            this.symbol = symbol;
            return this;
        }

        /**
         * Setter for faction.
         * @param  faction  String value for faction.
         * @return Builder
         */
        public Builder faction(String faction) {
            this.faction = faction;
            return this;
        }

        /**
         * Builds a new {@link AgentsRequest} object using the set fields.
         * @return {@link AgentsRequest}
         */
        public AgentsRequest build() {
            return new AgentsRequest(symbol, faction);
        }
    }
}
