/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package io.spacetraders.alpha.v200.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for Agent type.
 */
public class Agent {
    private String accountId;
    private String symbol;
    private String headquarters;
    private int credits;

    /**
     * Default constructor.
     */
    public Agent() {
    }

    /**
     * Initialization constructor.
     * @param  accountId  String value for accountId.
     * @param  symbol  String value for symbol.
     * @param  headquarters  String value for headquarters.
     * @param  credits  int value for credits.
     */
    public Agent(
            String accountId,
            String symbol,
            String headquarters,
            int credits) {
        this.accountId = accountId;
        this.symbol = symbol;
        this.headquarters = headquarters;
        this.credits = credits;
    }

    /**
     * Getter for AccountId.
     * @return Returns the String
     */
    @JsonGetter("accountId")
    public String getAccountId() {
        return accountId;
    }

    /**
     * Setter for AccountId.
     * @param accountId Value for String
     */
    @JsonSetter("accountId")
    public void setAccountId(String accountId) {
        this.accountId = accountId;
    }

    /**
     * Getter for Symbol.
     * @return Returns the String
     */
    @JsonGetter("symbol")
    public String getSymbol() {
        return symbol;
    }

    /**
     * Setter for Symbol.
     * @param symbol Value for String
     */
    @JsonSetter("symbol")
    public void setSymbol(String symbol) {
        this.symbol = symbol;
    }

    /**
     * Getter for Headquarters.
     * @return Returns the String
     */
    @JsonGetter("headquarters")
    public String getHeadquarters() {
        return headquarters;
    }

    /**
     * Setter for Headquarters.
     * @param headquarters Value for String
     */
    @JsonSetter("headquarters")
    public void setHeadquarters(String headquarters) {
        this.headquarters = headquarters;
    }

    /**
     * Getter for Credits.
     * @return Returns the int
     */
    @JsonGetter("credits")
    public int getCredits() {
        return credits;
    }

    /**
     * Setter for Credits.
     * @param credits Value for int
     */
    @JsonSetter("credits")
    public void setCredits(int credits) {
        this.credits = credits;
    }

    /**
     * Converts this Agent into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "Agent [" + "accountId=" + accountId + ", symbol=" + symbol + ", headquarters="
                + headquarters + ", credits=" + credits + "]";
    }

    /**
     * Builds a new {@link Agent.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link Agent.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(accountId, symbol, headquarters, credits);
        return builder;
    }

    /**
     * Class to build instances of {@link Agent}.
     */
    public static class Builder {
        private String accountId;
        private String symbol;
        private String headquarters;
        private int credits;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  accountId  String value for accountId.
         * @param  symbol  String value for symbol.
         * @param  headquarters  String value for headquarters.
         * @param  credits  int value for credits.
         */
        public Builder(String accountId, String symbol, String headquarters, int credits) {
            this.accountId = accountId;
            this.symbol = symbol;
            this.headquarters = headquarters;
            this.credits = credits;
        }

        /**
         * Setter for accountId.
         * @param  accountId  String value for accountId.
         * @return Builder
         */
        public Builder accountId(String accountId) {
            this.accountId = accountId;
            return this;
        }

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
         * Setter for headquarters.
         * @param  headquarters  String value for headquarters.
         * @return Builder
         */
        public Builder headquarters(String headquarters) {
            this.headquarters = headquarters;
            return this;
        }

        /**
         * Setter for credits.
         * @param  credits  int value for credits.
         * @return Builder
         */
        public Builder credits(int credits) {
            this.credits = credits;
            return this;
        }

        /**
         * Builds a new {@link Agent} object using the set fields.
         * @return {@link Agent}
         */
        public Agent build() {
            return new Agent(accountId, symbol, headquarters, credits);
        }
    }
}
