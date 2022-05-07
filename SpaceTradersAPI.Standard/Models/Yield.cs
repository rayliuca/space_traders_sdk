// <copyright file="Yield.cs" company="APIMatic">
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
    /// Yield.
    /// </summary>
    public class Yield
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Yield"/> class.
        /// </summary>
        public Yield()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Yield"/> class.
        /// </summary>
        /// <param name="tradeSymbol">tradeSymbol.</param>
        /// <param name="units">units.</param>
        public Yield(
            string tradeSymbol,
            int units)
        {
            this.TradeSymbol = tradeSymbol;
            this.Units = units;
        }

        /// <summary>
        /// Gets or sets TradeSymbol.
        /// </summary>
        [JsonProperty("tradeSymbol")]
        public string TradeSymbol { get; set; }

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

            return $"Yield : ({string.Join(", ", toStringOutput)})";
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

            return obj is Yield other &&
                ((this.TradeSymbol == null && other.TradeSymbol == null) || (this.TradeSymbol?.Equals(other.TradeSymbol) == true)) &&
                this.Units.Equals(other.Units);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TradeSymbol = {(this.TradeSymbol == null ? "null" : this.TradeSymbol == string.Empty ? "" : this.TradeSymbol)}");
            toStringOutput.Add($"this.Units = {this.Units}");
        }
    }
}