// <copyright file="Stats.cs" company="APIMatic">
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
    /// Stats.
    /// </summary>
    public class Stats
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stats"/> class.
        /// </summary>
        public Stats()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stats"/> class.
        /// </summary>
        /// <param name="fuelTank">fuelTank.</param>
        /// <param name="cargoLimit">cargoLimit.</param>
        /// <param name="jumpRange">jumpRange.</param>
        public Stats(
            int fuelTank,
            int cargoLimit,
            int jumpRange)
        {
            this.FuelTank = fuelTank;
            this.CargoLimit = cargoLimit;
            this.JumpRange = jumpRange;
        }

        /// <summary>
        /// Gets or sets FuelTank.
        /// </summary>
        [JsonProperty("fuelTank")]
        public int FuelTank { get; set; }

        /// <summary>
        /// Gets or sets CargoLimit.
        /// </summary>
        [JsonProperty("cargoLimit")]
        public int CargoLimit { get; set; }

        /// <summary>
        /// Gets or sets JumpRange.
        /// </summary>
        [JsonProperty("jumpRange")]
        public int JumpRange { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Stats : ({string.Join(", ", toStringOutput)})";
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

            return obj is Stats other &&
                this.FuelTank.Equals(other.FuelTank) &&
                this.CargoLimit.Equals(other.CargoLimit) &&
                this.JumpRange.Equals(other.JumpRange);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FuelTank = {this.FuelTank}");
            toStringOutput.Add($"this.CargoLimit = {this.CargoLimit}");
            toStringOutput.Add($"this.JumpRange = {this.JumpRange}");
        }
    }
}