// <copyright file="MarketTrade.cs" company="APIMatic">
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
    /// MarketTrade.
    /// </summary>
    public class MarketTrade
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketTrade"/> class.
        /// </summary>
        public MarketTrade()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketTrade"/> class.
        /// </summary>
        /// <param name="waypointSymbol">waypointSymbol.</param>
        /// <param name="tradeSymbol">tradeSymbol.</param>
        /// <param name="price">price.</param>
        /// <param name="tariff">tariff.</param>
        public MarketTrade(
            string waypointSymbol,
            string tradeSymbol,
            int price,
            int tariff)
        {
            this.WaypointSymbol = waypointSymbol;
            this.TradeSymbol = tradeSymbol;
            this.Price = price;
            this.Tariff = tariff;
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
        /// Gets or sets Price.
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets Tariff.
        /// </summary>
        [JsonProperty("tariff")]
        public int Tariff { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MarketTrade : ({string.Join(", ", toStringOutput)})";
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

            return obj is MarketTrade other &&
                ((this.WaypointSymbol == null && other.WaypointSymbol == null) || (this.WaypointSymbol?.Equals(other.WaypointSymbol) == true)) &&
                ((this.TradeSymbol == null && other.TradeSymbol == null) || (this.TradeSymbol?.Equals(other.TradeSymbol) == true)) &&
                this.Price.Equals(other.Price) &&
                this.Tariff.Equals(other.Tariff);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.WaypointSymbol = {(this.WaypointSymbol == null ? "null" : this.WaypointSymbol == string.Empty ? "" : this.WaypointSymbol)}");
            toStringOutput.Add($"this.TradeSymbol = {(this.TradeSymbol == null ? "null" : this.TradeSymbol == string.Empty ? "" : this.TradeSymbol)}");
            toStringOutput.Add($"this.Price = {this.Price}");
            toStringOutput.Add($"this.Tariff = {this.Tariff}");
        }
    }
}