/*
 * SpaceTradersAPILib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package io.spacetraders.alpha.v200.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;
import java.util.List;

/**
 * This is a model class for SystemsWaypointsResponse type.
 */
public class SystemsWaypointsResponse {
    private List<Waypoint> data;
    private Meta meta;

    /**
     * Default constructor.
     */
    public SystemsWaypointsResponse() {
    }

    /**
     * Initialization constructor.
     * @param  data  List of Waypoint value for data.
     * @param  meta  Meta value for meta.
     */
    public SystemsWaypointsResponse(
            List<Waypoint> data,
            Meta meta) {
        this.data = data;
        this.meta = meta;
    }

    /**
     * Getter for Data.
     * @return Returns the List of Waypoint
     */
    @JsonGetter("data")
    public List<Waypoint> getData() {
        return data;
    }

    /**
     * Setter for Data.
     * @param data Value for List of Waypoint
     */
    @JsonSetter("data")
    public void setData(List<Waypoint> data) {
        this.data = data;
    }

    /**
     * Getter for Meta.
     * @return Returns the Meta
     */
    @JsonGetter("meta")
    public Meta getMeta() {
        return meta;
    }

    /**
     * Setter for Meta.
     * @param meta Value for Meta
     */
    @JsonSetter("meta")
    public void setMeta(Meta meta) {
        this.meta = meta;
    }

    /**
     * Converts this SystemsWaypointsResponse into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "SystemsWaypointsResponse [" + "data=" + data + ", meta=" + meta + "]";
    }

    /**
     * Builds a new {@link SystemsWaypointsResponse.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link SystemsWaypointsResponse.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(data, meta);
        return builder;
    }

    /**
     * Class to build instances of {@link SystemsWaypointsResponse}.
     */
    public static class Builder {
        private List<Waypoint> data;
        private Meta meta;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  data  List of Waypoint value for data.
         * @param  meta  Meta value for meta.
         */
        public Builder(List<Waypoint> data, Meta meta) {
            this.data = data;
            this.meta = meta;
        }

        /**
         * Setter for data.
         * @param  data  List of Waypoint value for data.
         * @return Builder
         */
        public Builder data(List<Waypoint> data) {
            this.data = data;
            return this;
        }

        /**
         * Setter for meta.
         * @param  meta  Meta value for meta.
         * @return Builder
         */
        public Builder meta(Meta meta) {
            this.meta = meta;
            return this;
        }

        /**
         * Builds a new {@link SystemsWaypointsResponse} object using the set fields.
         * @return {@link SystemsWaypointsResponse}
         */
        public SystemsWaypointsResponse build() {
            return new SystemsWaypointsResponse(data, meta);
        }
    }
}