/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package io.spacetraders.alpha.v200.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for Data7 type.
 */
public class Data7 {
    private Cooldown cooldown;

    /**
     * Default constructor.
     */
    public Data7() {
    }

    /**
     * Initialization constructor.
     * @param  cooldown  Cooldown value for cooldown.
     */
    public Data7(
            Cooldown cooldown) {
        this.cooldown = cooldown;
    }

    /**
     * Getter for Cooldown.
     * @return Returns the Cooldown
     */
    @JsonGetter("cooldown")
    public Cooldown getCooldown() {
        return cooldown;
    }

    /**
     * Setter for Cooldown.
     * @param cooldown Value for Cooldown
     */
    @JsonSetter("cooldown")
    public void setCooldown(Cooldown cooldown) {
        this.cooldown = cooldown;
    }

    /**
     * Converts this Data7 into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "Data7 [" + "cooldown=" + cooldown + "]";
    }

    /**
     * Builds a new {@link Data7.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link Data7.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(cooldown);
        return builder;
    }

    /**
     * Class to build instances of {@link Data7}.
     */
    public static class Builder {
        private Cooldown cooldown;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  cooldown  Cooldown value for cooldown.
         */
        public Builder(Cooldown cooldown) {
            this.cooldown = cooldown;
        }

        /**
         * Setter for cooldown.
         * @param  cooldown  Cooldown value for cooldown.
         * @return Builder
         */
        public Builder cooldown(Cooldown cooldown) {
            this.cooldown = cooldown;
            return this;
        }

        /**
         * Builds a new {@link Data7} object using the set fields.
         * @return {@link Data7}
         */
        public Data7 build() {
            return new Data7(cooldown);
        }
    }
}