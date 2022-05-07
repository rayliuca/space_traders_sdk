// <copyright file="Ship.cs" company="APIMatic">
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
    /// Ship.
    /// </summary>
    public class Ship
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ship"/> class.
        /// </summary>
        public Ship()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ship"/> class.
        /// </summary>
        /// <param name="symbol">symbol.</param>
        /// <param name="frame">frame.</param>
        /// <param name="reactor">reactor.</param>
        /// <param name="engine">engine.</param>
        /// <param name="modules">modules.</param>
        /// <param name="mounts">mounts.</param>
        /// <param name="registration">registration.</param>
        /// <param name="integrity">integrity.</param>
        /// <param name="status">status.</param>
        /// <param name="location">location.</param>
        /// <param name="cargo">cargo.</param>
        /// <param name="fuel">fuel.</param>
        /// <param name="stats">stats.</param>
        public Ship(
            string symbol,
            string frame,
            string reactor,
            string engine,
            List<string> modules,
            List<string> mounts,
            Models.Registration1 registration,
            Models.Integrity integrity,
            string status,
            string location,
            List<Models.Cargo> cargo,
            int fuel,
            Models.Stats stats = null)
        {
            this.Symbol = symbol;
            this.Frame = frame;
            this.Reactor = reactor;
            this.Engine = engine;
            this.Modules = modules;
            this.Mounts = mounts;
            this.Registration = registration;
            this.Integrity = integrity;
            this.Stats = stats;
            this.Status = status;
            this.Location = location;
            this.Cargo = cargo;
            this.Fuel = fuel;
        }

        /// <summary>
        /// Gets or sets Symbol.
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

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

        /// <summary>
        /// Gets or sets Registration.
        /// </summary>
        [JsonProperty("registration")]
        public Models.Registration1 Registration { get; set; }

        /// <summary>
        /// Gets or sets Integrity.
        /// </summary>
        [JsonProperty("integrity")]
        public Models.Integrity Integrity { get; set; }

        /// <summary>
        /// Gets or sets Stats.
        /// </summary>
        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Stats Stats { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Location.
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets Cargo.
        /// </summary>
        [JsonProperty("cargo")]
        public List<Models.Cargo> Cargo { get; set; }

        /// <summary>
        /// Gets or sets Fuel.
        /// </summary>
        [JsonProperty("fuel")]
        public int Fuel { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Ship : ({string.Join(", ", toStringOutput)})";
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

            return obj is Ship other &&
                ((this.Symbol == null && other.Symbol == null) || (this.Symbol?.Equals(other.Symbol) == true)) &&
                ((this.Frame == null && other.Frame == null) || (this.Frame?.Equals(other.Frame) == true)) &&
                ((this.Reactor == null && other.Reactor == null) || (this.Reactor?.Equals(other.Reactor) == true)) &&
                ((this.Engine == null && other.Engine == null) || (this.Engine?.Equals(other.Engine) == true)) &&
                ((this.Modules == null && other.Modules == null) || (this.Modules?.Equals(other.Modules) == true)) &&
                ((this.Mounts == null && other.Mounts == null) || (this.Mounts?.Equals(other.Mounts) == true)) &&
                ((this.Registration == null && other.Registration == null) || (this.Registration?.Equals(other.Registration) == true)) &&
                ((this.Integrity == null && other.Integrity == null) || (this.Integrity?.Equals(other.Integrity) == true)) &&
                ((this.Stats == null && other.Stats == null) || (this.Stats?.Equals(other.Stats) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Location == null && other.Location == null) || (this.Location?.Equals(other.Location) == true)) &&
                ((this.Cargo == null && other.Cargo == null) || (this.Cargo?.Equals(other.Cargo) == true)) &&
                this.Fuel.Equals(other.Fuel);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Symbol = {(this.Symbol == null ? "null" : this.Symbol == string.Empty ? "" : this.Symbol)}");
            toStringOutput.Add($"this.Frame = {(this.Frame == null ? "null" : this.Frame == string.Empty ? "" : this.Frame)}");
            toStringOutput.Add($"this.Reactor = {(this.Reactor == null ? "null" : this.Reactor == string.Empty ? "" : this.Reactor)}");
            toStringOutput.Add($"this.Engine = {(this.Engine == null ? "null" : this.Engine == string.Empty ? "" : this.Engine)}");
            toStringOutput.Add($"this.Modules = {(this.Modules == null ? "null" : $"[{string.Join(", ", this.Modules)} ]")}");
            toStringOutput.Add($"this.Mounts = {(this.Mounts == null ? "null" : $"[{string.Join(", ", this.Mounts)} ]")}");
            toStringOutput.Add($"this.Registration = {(this.Registration == null ? "null" : this.Registration.ToString())}");
            toStringOutput.Add($"this.Integrity = {(this.Integrity == null ? "null" : this.Integrity.ToString())}");
            toStringOutput.Add($"this.Stats = {(this.Stats == null ? "null" : this.Stats.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.Location = {(this.Location == null ? "null" : this.Location == string.Empty ? "" : this.Location)}");
            toStringOutput.Add($"this.Cargo = {(this.Cargo == null ? "null" : $"[{string.Join(", ", this.Cargo)} ]")}");
            toStringOutput.Add($"this.Fuel = {this.Fuel}");
        }
    }
}