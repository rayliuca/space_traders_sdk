// <copyright file="Data1.cs" company="APIMatic">
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
    /// Data1.
    /// </summary>
    public class Data1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data1"/> class.
        /// </summary>
        public Data1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data1"/> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="agent">agent.</param>
        /// <param name="faction">faction.</param>
        /// <param name="contract">contract.</param>
        /// <param name="ship">ship.</param>
        public Data1(
            string token = null,
            Models.Agent agent = null,
            Models.Faction faction = null,
            Models.Contract contract = null,
            Models.Ship ship = null)
        {
            this.Token = token;
            this.Agent = agent;
            this.Faction = faction;
            this.Contract = contract;
            this.Ship = ship;
        }

        /// <summary>
        /// Gets or sets Token.
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets Agent.
        /// </summary>
        [JsonProperty("agent", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Agent Agent { get; set; }

        /// <summary>
        /// Gets or sets Faction.
        /// </summary>
        [JsonProperty("faction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Faction Faction { get; set; }

        /// <summary>
        /// Gets or sets Contract.
        /// </summary>
        [JsonProperty("contract", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Contract Contract { get; set; }

        /// <summary>
        /// Gets or sets Ship.
        /// </summary>
        [JsonProperty("ship", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Ship Ship { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data1 other &&
                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true)) &&
                ((this.Agent == null && other.Agent == null) || (this.Agent?.Equals(other.Agent) == true)) &&
                ((this.Faction == null && other.Faction == null) || (this.Faction?.Equals(other.Faction) == true)) &&
                ((this.Contract == null && other.Contract == null) || (this.Contract?.Equals(other.Contract) == true)) &&
                ((this.Ship == null && other.Ship == null) || (this.Ship?.Equals(other.Ship) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Token = {(this.Token == null ? "null" : this.Token == string.Empty ? "" : this.Token)}");
            toStringOutput.Add($"this.Agent = {(this.Agent == null ? "null" : this.Agent.ToString())}");
            toStringOutput.Add($"this.Faction = {(this.Faction == null ? "null" : this.Faction.ToString())}");
            toStringOutput.Add($"this.Contract = {(this.Contract == null ? "null" : this.Contract.ToString())}");
            toStringOutput.Add($"this.Ship = {(this.Ship == null ? "null" : this.Ship.ToString())}");
        }
    }
}