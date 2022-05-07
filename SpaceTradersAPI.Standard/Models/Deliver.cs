// <copyright file="Deliver.cs" company="APIMatic">
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
    /// Deliver.
    /// </summary>
    public class Deliver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Deliver"/> class.
        /// </summary>
        public Deliver()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Deliver"/> class.
        /// </summary>
        /// <param name="tradeSymbol">tradeSymbol.</param>
        /// <param name="destination">destination.</param>
        /// <param name="units">units.</param>
        /// <param name="fulfilled">fulfilled.</param>
        public Deliver(
            string tradeSymbol,
            string destination,
            int units,
            int fulfilled)
        {
            this.TradeSymbol = tradeSymbol;
            this.Destination = destination;
            this.Units = units;
            this.Fulfilled = fulfilled;
        }

        /// <summary>
        /// Gets or sets TradeSymbol.
        /// </summary>
        [JsonProperty("tradeSymbol")]
        public string TradeSymbol { get; set; }

        /// <summary>
        /// Gets or sets Destination.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or sets Units.
        /// </summary>
        [JsonProperty("units")]
        public int Units { get; set; }

        /// <summary>
        /// Gets or sets Fulfilled.
        /// </summary>
        [JsonProperty("fulfilled")]
        public int Fulfilled { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Deliver : ({string.Join(", ", toStringOutput)})";
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

            return obj is Deliver other &&
                ((this.TradeSymbol == null && other.TradeSymbol == null) || (this.TradeSymbol?.Equals(other.TradeSymbol) == true)) &&
                ((this.Destination == null && other.Destination == null) || (this.Destination?.Equals(other.Destination) == true)) &&
                this.Units.Equals(other.Units) &&
                this.Fulfilled.Equals(other.Fulfilled);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TradeSymbol = {(this.TradeSymbol == null ? "null" : this.TradeSymbol == string.Empty ? "" : this.TradeSymbol)}");
            toStringOutput.Add($"this.Destination = {(this.Destination == null ? "null" : this.Destination == string.Empty ? "" : this.Destination)}");
            toStringOutput.Add($"this.Units = {this.Units}");
            toStringOutput.Add($"this.Fulfilled = {this.Fulfilled}");
        }
    }
}