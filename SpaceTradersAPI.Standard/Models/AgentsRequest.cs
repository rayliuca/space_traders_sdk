// <copyright file="AgentsRequest.cs" company="APIMatic">
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
    /// AgentsRequest.
    /// </summary>
    public class AgentsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsRequest"/> class.
        /// </summary>
        public AgentsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsRequest"/> class.
        /// </summary>
        /// <param name="symbol">symbol.</param>
        /// <param name="faction">faction.</param>
        public AgentsRequest(
            string symbol = null,
            string faction = "COMMERCE_REPUBLIC")
        {
            this.Symbol = symbol;
            this.Faction = faction;
        }

        /// <summary>
        /// How other agents will see your ships and information.
        /// </summary>
        [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string Symbol { get; set; }

        /// <summary>
        /// The faction you choose determines your headquarters.
        /// </summary>
        [JsonProperty("faction", NullValueHandling = NullValueHandling.Ignore)]
        public string Faction { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AgentsRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is AgentsRequest other &&
                ((this.Symbol == null && other.Symbol == null) || (this.Symbol?.Equals(other.Symbol) == true)) &&
                ((this.Faction == null && other.Faction == null) || (this.Faction?.Equals(other.Faction) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Symbol = {(this.Symbol == null ? "null" : this.Symbol == string.Empty ? "" : this.Symbol)}");
            toStringOutput.Add($"this.Faction = {(this.Faction == null ? "null" : this.Faction == string.Empty ? "" : this.Faction)}");
        }
    }
}