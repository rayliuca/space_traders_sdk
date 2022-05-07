// <copyright file="Data15.cs" company="APIMatic">
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
    /// Data15.
    /// </summary>
    public class Data15
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data15"/> class.
        /// </summary>
        public Data15()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data15"/> class.
        /// </summary>
        /// <param name="navigation">navigation.</param>
        /// <param name="fuelCost">fuelCost.</param>
        public Data15(
            Models.ShipNavigation navigation = null,
            int? fuelCost = null)
        {
            this.Navigation = navigation;
            this.FuelCost = fuelCost;
        }

        /// <summary>
        /// Gets or sets Navigation.
        /// </summary>
        [JsonProperty("navigation", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ShipNavigation Navigation { get; set; }

        /// <summary>
        /// Gets or sets FuelCost.
        /// </summary>
        [JsonProperty("fuelCost", NullValueHandling = NullValueHandling.Ignore)]
        public int? FuelCost { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data15 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data15 other &&
                ((this.Navigation == null && other.Navigation == null) || (this.Navigation?.Equals(other.Navigation) == true)) &&
                ((this.FuelCost == null && other.FuelCost == null) || (this.FuelCost?.Equals(other.FuelCost) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Navigation = {(this.Navigation == null ? "null" : this.Navigation.ToString())}");
            toStringOutput.Add($"this.FuelCost = {(this.FuelCost == null ? "null" : this.FuelCost.ToString())}");
        }
    }
}