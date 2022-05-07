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
 * This is a model class for Data16 type.
 */
public class Data16 {
    private ShipNavigation navigation;

    /**
     * Default constructor.
     */
    public Data16() {
    }

    /**
     * Initialization constructor.
     * @param  navigation  ShipNavigation value for navigation.
     */
    public Data16(
            ShipNavigation navigation) {
        this.navigation = navigation;
    }

    /**
     * Getter for Navigation.
     * @return Returns the ShipNavigation
     */
    @JsonGetter("navigation")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public ShipNavigation getNavigation() {
        return navigation;
    }

    /**
     * Setter for Navigation.
     * @param navigation Value for ShipNavigation
     */
    @JsonSetter("navigation")
    public void setNavigation(ShipNavigation navigation) {
        this.navigation = navigation;
    }

    /**
     * Converts this Data16 into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "Data16 [" + "navigation=" + navigation + "]";
    }

    /**
     * Builds a new {@link Data16.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link Data16.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .navigation(getNavigation());
        return builder;
    }

    /**
     * Class to build instances of {@link Data16}.
     */
    public static class Builder {
        private ShipNavigation navigation;



        /**
         * Setter for navigation.
         * @param  navigation  ShipNavigation value for navigation.
         * @return Builder
         */
        public Builder navigation(ShipNavigation navigation) {
            this.navigation = navigation;
            return this;
        }

        /**
         * Builds a new {@link Data16} object using the set fields.
         * @return {@link Data16}
         */
        public Data16 build() {
            return new Data16(navigation);
        }
    }
}
