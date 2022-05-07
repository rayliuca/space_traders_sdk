// <copyright file="Trade.cs" company="APIMatic">
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
    /// Trade.
    /// </summary>
    public class Trade
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Trade"/> class.
        /// </summary>
        public Trade()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Trade"/> class.
        /// </summary>
        /// <param name="waypointSymbol">waypointSymbol.</param>
        /// <param name="tradeSymbol">tradeSymbol.</param>
        /// <param name="credits">credits.</param>
        /// <param name="units">units.</param>
        public Trade(
            string waypointSymbol,
            string tradeSymbol,
            int credits,
            int units)
        {
            this.WaypointSymbol = waypointSymbol;
            this.TradeSymbol = tradeSymbol;
            this.Credits = credits;
            this.Units = units;
        }

        /// <summary>
        /// Gets or sets WaypointSymbol.
        /// </summary>
        [JsonProperty("waypointSymbol")]
        public string WaypointSymbol { get; set; }

        /// <summary>
        /// Gets or sets TradeSymbol.
        /// </summary>
        [JsonProperty("tradeSymbol")]
        public string TradeSymbol { get; set; }

        /// <summary>
        /// Gets or sets Credits.
        /// </summary>
        [JsonProperty("credits")]
        public int Credits { get; set; }

        /// <summary>
        /// Gets or sets Units.
        /// </summary>
        [JsonProperty("units")]
        public int Units { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Trade : ({string.Join(", ", toStringOutput)})";
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

            return obj is Trade other &&
                ((this.WaypointSymbol == null && other.WaypointSymbol == null) || (this.WaypointSymbol?.Equals(other.WaypointSymbol) == true)) &&
                ((this.TradeSymbol == null && other.TradeSymbol == null) || (this.TradeSymbol?.Equals(other.TradeSymbol) == true)) &&
                this.Credits.Equals(other.Credits) &&
                this.Units.Equals(other.Units);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.WaypointSymbol = {(this.WaypointSymbol == null ? "null" : this.WaypointSymbol == string.Empty ? "" : this.WaypointSymbol)}");
            toStringOutput.Add($"this.TradeSymbol = {(this.TradeSymbol == null ? "null" : this.TradeSymbol == string.Empty ? "" : this.TradeSymbol)}");
            toStringOutput.Add($"this.Credits = {this.Credits}");
            toStringOutput.Add($"this.Units = {this.Units}");
        }
    }
}