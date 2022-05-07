/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package io.spacetraders.alpha.v200.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for Payment type.
 */
public class Payment {
    private int onAccepted;
    private int onFulfilled;

    /**
     * Default constructor.
     */
    public Payment() {
    }

    /**
     * Initialization constructor.
     * @param  onAccepted  int value for onAccepted.
     * @param  onFulfilled  int value for onFulfilled.
     */
    public Payment(
            int onAccepted,
            int onFulfilled) {
        this.onAccepted = onAccepted;
        this.onFulfilled = onFulfilled;
    }

    /**
     * Getter for OnAccepted.
     * @return Returns the int
     */
    @JsonGetter("onAccepted")
    public int getOnAccepted() {
        return onAccepted;
    }

    /**
     * Setter for OnAccepted.
     * @param onAccepted Value for int
     */
    @JsonSetter("onAccepted")
    public void setOnAccepted(int onAccepted) {
        this.onAccepted = onAccepted;
    }

    /**
     * Getter for OnFulfilled.
     * @return Returns the int
     */
    @JsonGetter("onFulfilled")
    public int getOnFulfilled() {
        return onFulfilled;
    }

    /**
     * Setter for OnFulfilled.
     * @param onFulfilled Value for int
     */
    @JsonSetter("onFulfilled")
    public void setOnFulfilled(int onFulfilled) {
        this.onFulfilled = onFulfilled;
    }

    /**
     * Converts this Payment into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "Payment [" + "onAccepted=" + onAccepted + ", onFulfilled=" + onFulfilled + "]";
    }

    /**
     * Builds a new {@link Payment.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link Payment.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(onAccepted, onFulfilled);
        return builder;
    }

    /**
     * Class to build instances of {@link Payment}.
     */
    public static class Builder {
        private int onAccepted;
        private int onFulfilled;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  onAccepted  int value for onAccepted.
         * @param  onFulfilled  int value for onFulfilled.
         */
        public Builder(int onAccepted, int onFulfilled) {
            this.onAccepted = onAccepted;
            this.onFulfilled = onFulfilled;
        }

        /**
         * Setter for onAccepted.
         * @param  onAccepted  int value for onAccepted.
         * @return Builder
         */
        public Builder onAccepted(int onAccepted) {
            this.onAccepted = onAccepted;
            return this;
        }

        /**
         * Setter for onFulfilled.
         * @param  onFulfilled  int value for onFulfilled.
         * @return Builder
         */
        public Builder onFulfilled(int onFulfilled) {
            this.onFulfilled = onFulfilled;
            return this;
        }

        /**
         * Builds a new {@link Payment} object using the set fields.
         * @return {@link Payment}
         */
        public Payment build() {
            return new Payment(onAccepted, onFulfilled);
        }
    }
}