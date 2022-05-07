// <copyright file="Data12.cs" company="APIMatic">
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
    /// Data12.
    /// </summary>
    public class Data12
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data12"/> class.
        /// </summary>
        public Data12()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data12"/> class.
        /// </summary>
        /// <param name="credits">credits.</param>
        /// <param name="fuel">fuel.</param>
        public Data12(
            int credits,
            int fuel)
        {
            this.Credits = credits;
            this.Fuel = fuel;
        }

        /// <summary>
        /// Gets or sets Credits.
        /// </summary>
        [JsonProperty("credits")]
        public int Credits { get; set; }

        /// <summary>
        /// Gets or sets Fuel.
        /// </summary>
        [JsonProperty("fuel")]
        public int Fuel { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data12 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data12 other &&
                this.Credits.Equals(other.Credits) &&
                this.Fuel.Equals(other.Fuel);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Credits = {this.Credits}");
            toStringOutput.Add($"this.Fuel = {this.Fuel}");
        }
    }
}