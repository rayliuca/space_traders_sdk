/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package io.spacetraders.alpha.v200.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for Registration type.
 */
public class Registration {
    private String factionSymbol;
    private String role;

    /**
     * Default constructor.
     */
    public Registration() {
    }

    /**
     * Initialization constructor.
     * @param  factionSymbol  String value for factionSymbol.
     * @param  role  String value for role.
     */
    public Registration(
            String factionSymbol,
            String role) {
        this.factionSymbol = factionSymbol;
        this.role = role;
    }

    /**
     * Getter for FactionSymbol.
     * @return Returns the String
     */
    @JsonGetter("factionSymbol")
    public String getFactionSymbol() {
        return factionSymbol;
    }

    /**
     * Setter for FactionSymbol.
     * @param factionSymbol Value for String
     */
    @JsonSetter("factionSymbol")
    public void setFactionSymbol(String factionSymbol) {
        this.factionSymbol = factionSymbol;
    }

    /**
     * Getter for Role.
     * @return Returns the String
     */
    @JsonGetter("role")
    public String getRole() {
        return role;
    }

    /**
     * Setter for Role.
     * @param role Value for String
     */
    @JsonSetter("role")
    public void setRole(String role) {
        this.role = role;
    }

    /**
     * Converts this Registration into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "Registration [" + "factionSymbol=" + factionSymbol + ", role=" + role + "]";
    }

    /**
     * Builds a new {@link Registration.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link Registration.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(factionSymbol, role);
        return builder;
    }

    /**
     * Class to build instances of {@link Registration}.
     */
    public static class Builder {
        private String factionSymbol;
        private String role;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  factionSymbol  String value for factionSymbol.
         * @param  role  String value for role.
         */
        public Builder(String factionSymbol, String role) {
            this.factionSymbol = factionSymbol;
            this.role = role;
        }

        /**
         * Setter for factionSymbol.
         * @param  factionSymbol  String value for factionSymbol.
         * @return Builder
         */
        public Builder factionSymbol(String factionSymbol) {
            this.factionSymbol = factionSymbol;
            return this;
        }

        /**
         * Setter for role.
         * @param  role  String value for role.
         * @return Builder
         */
        public Builder role(String role) {
            this.role = role;
            return this;
        }

        /**
         * Builds a new {@link Registration} object using the set fields.
         * @return {@link Registration}
         */
        public Registration build() {
            return new Registration(factionSymbol, role);
        }
    }
}