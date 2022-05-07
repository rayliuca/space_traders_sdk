/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package io.spacetraders.alpha.v200.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for Integrity type.
 */
public class Integrity {
    private double frame;
    private double reactor;
    private double engine;

    /**
     * Default constructor.
     */
    public Integrity() {
    }

    /**
     * Initialization constructor.
     * @param  frame  double value for frame.
     * @param  reactor  double value for reactor.
     * @param  engine  double value for engine.
     */
    public Integrity(
            double frame,
            double reactor,
            double engine) {
        this.frame = frame;
        this.reactor = reactor;
        this.engine = engine;
    }

    /**
     * Getter for Frame.
     * @return Returns the double
     */
    @JsonGetter("frame")
    public double getFrame() {
        return frame;
    }

    /**
     * Setter for Frame.
     * @param frame Value for double
     */
    @JsonSetter("frame")
    public void setFrame(double frame) {
        this.frame = frame;
    }

    /**
     * Getter for Reactor.
     * @return Returns the double
     */
    @JsonGetter("reactor")
    public double getReactor() {
        return reactor;
    }

    /**
     * Setter for Reactor.
     * @param reactor Value for double
     */
    @JsonSetter("reactor")
    public void setReactor(double reactor) {
        this.reactor = reactor;
    }

    /**
     * Getter for Engine.
     * @return Returns the double
     */
    @JsonGetter("engine")
    public double getEngine() {
        return engine;
    }

    /**
     * Setter for Engine.
     * @param engine Value for double
     */
    @JsonSetter("engine")
    public void setEngine(double engine) {
        this.engine = engine;
    }

    /**
     * Converts this Integrity into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "Integrity [" + "frame=" + frame + ", reactor=" + reactor + ", engine=" + engine
                + "]";
    }

    /**
     * Builds a new {@link Integrity.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link Integrity.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(frame, reactor, engine);
        return builder;
    }

    /**
     * Class to build instances of {@link Integrity}.
     */
    public static class Builder {
        private double frame;
        private double reactor;
        private double engine;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  frame  double value for frame.
         * @param  reactor  double value for reactor.
         * @param  engine  double value for engine.
         */
        public Builder(double frame, double reactor, double engine) {
            this.frame = frame;
            this.reactor = reactor;
            this.engine = engine;
        }

        /**
         * Setter for frame.
         * @param  frame  double value for frame.
         * @return Builder
         */
        public Builder frame(double frame) {
            this.frame = frame;
            return this;
        }

        /**
         * Setter for reactor.
         * @param  reactor  double value for reactor.
         * @return Builder
         */
        public Builder reactor(double reactor) {
            this.reactor = reactor;
            return this;
        }

        /**
         * Setter for engine.
         * @param  engine  double value for engine.
         * @return Builder
         */
        public Builder engine(double engine) {
            this.engine = engine;
            return this;
        }

        /**
         * Builds a new {@link Integrity} object using the set fields.
         * @return {@link Integrity}
         */
        public Integrity build() {
            return new Integrity(frame, reactor, engine);
        }
    }
}