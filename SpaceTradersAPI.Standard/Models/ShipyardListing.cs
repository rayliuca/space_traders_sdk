// <copyright file="ShipyardListing.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace SpaceTradersAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using SpaceTradersAPI.Standard;
    using SpaceTradersAPI.Standard.Utilities;

    /// <summary>
    /// ShipyardListing.
    /// </summary>
    public class ShipyardListing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipyardListing"/> class.
        /// </summary>
        public ShipyardListing()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipyardListing"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="waypoint">waypoint.</param>
        /// <param name="price">price.</param>
        /// <param name="role">role.</param>
        /// <param name="frame">frame.</param>
        /// <param name="reactor">reactor.</param>
        /// <param name="engine">engine.</param>
        /// <param name="modules">modules.</param>
        /// <param name="mounts">mounts.</param>
        public ShipyardListing(
            string id,
            string waypoint,
            int price,
            string role,
            string frame,
            string reactor,
            string engine,
            List<string> modules,
            List<string> mounts)
        {
            this.Id = id;
            this.Waypoint = waypoint;
            this.Price = price;
            this.Role = role;
            this.Frame = frame;
            this.Reactor = reactor;
            this.Engine = engine;
            this.Modules = modules;
            this.Mounts = mounts;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Waypoint.
        /// </summary>
        [JsonProperty("waypoint")]
        public string Waypoint { get; set; }

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets Role.
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }

        /// <summary>
        /// Gets or sets Frame.
        /// </summary>
        [JsonProperty("frame")]
        public string Frame { get; set; }

        /// <summary>
        /// Gets or sets Reactor.
        /// </summary>
        [JsonProperty("reactor")]
        public string Reactor { get; set; }

        /// <summary>
        /// Gets or sets Engine.
        /// </summary>
        [JsonProperty("engine")]
        public string Engine { get; set; }

        /// <summary>
        /// Gets or sets Modules.
        /// </summary>
        [JsonProperty("modules")]
        public List<string> Modules { get; set; }

        /// <summary>
        /// Gets or sets Mounts.
        /// </summary>
        [JsonProperty("mounts")]
        public List<string> Mounts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ShipyardListing : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is ShipyardListing other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Waypoint == null && other.Waypoint == null) || (this.Waypoint?.Equals(other.Waypoint) == true)) &&
                this.Price.Equals(other.Price) &&
                ((this.Role == null && other.Role == null) || (this.Role?.Equals(other.Role) == true)) &&
                ((this.Frame == null && other.Frame == null) || (this.Frame?.Equals(other.Frame) == true)) &&
                ((this.Reactor == null && other.Reactor == null) || (this.Reactor?.Equals(other.Reactor) == true)) &&
                ((this.Engine == null && other.Engine == null) || (this.Engine?.Equals(other.Engine) == true)) &&
                ((this.Modules == null && other.Modules == null) || (this.Modules?.Equals(other.Modules) == true)) &&
                ((this.Mounts == null && other.Mounts == null) || (this.Mounts?.Equals(other.Mounts) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Waypoint = {(this.Waypoint == null ? "null" : this.Waypoint == string.Empty ? "" : this.Waypoint)}");
            toStringOutput.Add($"this.Price = {this.Price}");
            toStringOutput.Add($"this.Role = {(this.Role == null ? "null" : this.Role == string.Empty ? "" : this.Role)}");
            toStringOutput.Add($"this.Frame = {(this.Frame == null ? "null" : this.Frame == string.Empty ? "" : this.Frame)}");
            toStringOutput.Add($"this.Reactor = {(this.Reactor == null ? "null" : this.Reactor == string.Empty ? "" : this.Reactor)}");
            toStringOutput.Add($"this.Engine = {(this.Engine == null ? "null" : this.Engine == string.Empty ? "" : this.Engine)}");
            toStringOutput.Add($"this.Modules = {(this.Modules == null ? "null" : $"[{string.Join(", ", this.Modules)} ]")}");
            toStringOutput.Add($"this.Mounts = {(this.Mounts == null ? "null" : $"[{string.Join(", ", this.Mounts)} ]")}");
        }
    }
}