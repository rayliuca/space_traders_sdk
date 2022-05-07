// <copyright file="Data17.cs" company="APIMatic">
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
    /// Data17.
    /// </summary>
    public class Data17
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data17"/> class.
        /// </summary>
        public Data17()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data17"/> class.
        /// </summary>
        /// <param name="ship">ship.</param>
        /// <param name="credits">credits.</param>
        public Data17(
            Models.Ship ship = null,
            int? credits = null)
        {
            this.Ship = ship;
            this.Credits = credits;
        }

        /// <summary>
        /// Gets or sets Ship.
        /// </summary>
        [JsonProperty("ship", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Ship Ship { get; set; }

        /// <summary>
        /// Gets or sets Credits.
        /// </summary>
        [JsonProperty("credits", NullValueHandling = NullValueHandling.Ignore)]
        public int? Credits { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data17 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data17 other &&
                ((this.Ship == null && other.Ship == null) || (this.Ship?.Equals(other.Ship) == true)) &&
                ((this.Credits == null && other.Credits == null) || (this.Credits?.Equals(other.Credits) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ship = {(this.Ship == null ? "null" : this.Ship.ToString())}");
            toStringOutput.Add($"this.Credits = {(this.Credits == null ? "null" : this.Credits.ToString())}");
        }
    }
}