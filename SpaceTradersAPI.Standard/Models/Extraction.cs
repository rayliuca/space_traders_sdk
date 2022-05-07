// <copyright file="Extraction.cs" company="APIMatic">
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
    /// Extraction.
    /// </summary>
    public class Extraction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Extraction"/> class.
        /// </summary>
        public Extraction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Extraction"/> class.
        /// </summary>
        /// <param name="shipSymbol">shipSymbol.</param>
        /// <param name="mYield">yield.</param>
        public Extraction(
            string shipSymbol,
            Models.Yield mYield)
        {
            this.ShipSymbol = shipSymbol;
            this.MYield = mYield;
        }

        /// <summary>
        /// Gets or sets ShipSymbol.
        /// </summary>
        [JsonProperty("shipSymbol")]
        public string ShipSymbol { get; set; }

        /// <summary>
        /// Gets or sets MYield.
        /// </summary>
        [JsonProperty("yield")]
        public Models.Yield MYield { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Extraction : ({string.Join(", ", toStringOutput)})";
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

            return obj is Extraction other &&
                ((this.ShipSymbol == null && other.ShipSymbol == null) || (this.ShipSymbol?.Equals(other.ShipSymbol) == true)) &&
                ((this.MYield == null && other.MYield == null) || (this.MYield?.Equals(other.MYield) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ShipSymbol = {(this.ShipSymbol == null ? "null" : this.ShipSymbol == string.Empty ? "" : this.ShipSymbol)}");
            toStringOutput.Add($"this.MYield = {(this.MYield == null ? "null" : this.MYield.ToString())}");
        }
    }
}