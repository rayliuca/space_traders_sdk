// <copyright file="Data18.cs" company="APIMatic">
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
    /// Data18.
    /// </summary>
    public class Data18
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data18"/> class.
        /// </summary>
        public Data18()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data18"/> class.
        /// </summary>
        /// <param name="exports">exports.</param>
        /// <param name="imports">imports.</param>
        /// <param name="exchange">exchange.</param>
        public Data18(
            List<Models.MarketTrade> exports,
            List<Models.MarketTrade> imports,
            List<Models.MarketTrade> exchange)
        {
            this.Exports = exports;
            this.Imports = imports;
            this.Exchange = exchange;
        }

        /// <summary>
        /// Gets or sets Exports.
        /// </summary>
        [JsonProperty("exports")]
        public List<Models.MarketTrade> Exports { get; set; }

        /// <summary>
        /// Gets or sets Imports.
        /// </summary>
        [JsonProperty("imports")]
        public List<Models.MarketTrade> Imports { get; set; }

        /// <summary>
        /// Gets or sets Exchange.
        /// </summary>
        [JsonProperty("exchange")]
        public List<Models.MarketTrade> Exchange { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data18 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data18 other &&
                ((this.Exports == null && other.Exports == null) || (this.Exports?.Equals(other.Exports) == true)) &&
                ((this.Imports == null && other.Imports == null) || (this.Imports?.Equals(other.Imports) == true)) &&
                ((this.Exchange == null && other.Exchange == null) || (this.Exchange?.Equals(other.Exchange) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Exports = {(this.Exports == null ? "null" : $"[{string.Join(", ", this.Exports)} ]")}");
            toStringOutput.Add($"this.Imports = {(this.Imports == null ? "null" : $"[{string.Join(", ", this.Imports)} ]")}");
            toStringOutput.Add($"this.Exchange = {(this.Exchange == null ? "null" : $"[{string.Join(", ", this.Exchange)} ]")}");
        }
    }
}