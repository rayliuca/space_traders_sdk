/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package io.spacetraders.alpha.v200.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for Data10 type.
 */
public class Data10 {
    private Jump jump;
    private Cooldown cooldown;

    /**
     * Default constructor.
     */
    public Data10() {
    }

    /**
     * Initialization constructor.
     * @param  jump  Jump value for jump.
     * @param  cooldown  Cooldown value for cooldown.
     */
    public Data10(
            Jump jump,
            Cooldown cooldown) {
        this.jump = jump;
        this.cooldown = cooldown;
    }

    /**
     * Getter for Jump.
     * @return Returns the Jump
     */
    @JsonGetter("jump")
    public Jump getJump() {
        return jump;
    }

    /**
     * Setter for Jump.
     * @param jump Value for Jump
     */
    @JsonSetter("jump")
    public void setJump(Jump jump) {
        this.jump = jump;
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
     * Converts this Data10 into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "Data10 [" + "jump=" + jump + ", cooldown=" + cooldown + "]";
    }

    /**
     * Builds a new {@link Data10.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link Data10.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(jump, cooldown);
        return builder;
    }

    /**
     * Class to build instances of {@link Data10}.
     */
    public static class Builder {
        private Jump jump;
        private Cooldown cooldown;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  jump  Jump value for jump.
         * @param  cooldown  Cooldown value for cooldown.
         */
        public Builder(Jump jump, Cooldown cooldown) {
            this.jump = jump;
            this.cooldown = cooldown;
        }

        /**
         * Setter for jump.
         * @param  jump  Jump value for jump.
         * @return Builder
         */
        public Builder jump(Jump jump) {
            this.jump = jump;
            return this;
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
         * Builds a new {@link Data10} object using the set fields.
         * @return {@link Data10}
         */
        public Data10 build() {
            return new Data10(jump, cooldown);
        }
    }
}
