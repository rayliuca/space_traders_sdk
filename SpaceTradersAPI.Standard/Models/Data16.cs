// <copyright file="Data16.cs" company="APIMatic">
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
    /// Data16.
    /// </summary>
    public class Data16
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data16"/> class.
        /// </summary>
        public Data16()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data16"/> class.
        /// </summary>
        /// <param name="navigation">navigation.</param>
        public Data16(
            Models.ShipNavigation navigation = null)
        {
            this.Navigation = navigation;
        }

        /// <summary>
        /// Gets or sets Navigation.
        /// </summary>
        [JsonProperty("navigation", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ShipNavigation Navigation { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data16 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data16 other &&
                ((this.Navigation == null && other.Navigation == null) || (this.Navigation?.Equals(other.Navigation) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Navigation = {(this.Navigation == null ? "null" : this.Navigation.ToString())}");
        }
    }
}