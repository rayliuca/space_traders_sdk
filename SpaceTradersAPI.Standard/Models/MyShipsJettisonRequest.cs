// <copyright file="MyShipsJettisonRequest.cs" company="APIMatic">
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
    /// MyShipsJettisonRequest.
    /// </summary>
    public class MyShipsJettisonRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyShipsJettisonRequest"/> class.
        /// </summary>
        public MyShipsJettisonRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyShipsJettisonRequest"/> class.
        /// </summary>
        /// <param name="tradeSymbol">tradeSymbol.</param>
        /// <param name="units">units.</param>
        public MyShipsJettisonRequest(
            string tradeSymbol = null,
            int? units = null)
        {
            this.TradeSymbol = tradeSymbol;
            this.Units = units;
        }

        /// <summary>
        /// Gets or sets TradeSymbol.
        /// </summary>
        [JsonProperty("tradeSymbol", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeSymbol { get; set; }

        /// <summary>
        /// Gets or sets Units.
        /// </summary>
        [JsonProperty("units", NullValueHandling = NullValueHandling.Ignore)]
        public int? Units { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MyShipsJettisonRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is MyShipsJettisonRequest other &&
                ((this.TradeSymbol == null && other.TradeSymbol == null) || (this.TradeSymbol?.Equals(other.TradeSymbol) == true)) &&
                ((this.Units == null && other.Units == null) || (this.Units?.Equals(other.Units) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TradeSymbol = {(this.TradeSymbol == null ? "null" : this.TradeSymbol == string.Empty ? "" : this.TradeSymbol)}");
            toStringOutput.Add($"this.Units = {(this.Units == null ? "null" : this.Units.ToString())}");
        }
    }
}