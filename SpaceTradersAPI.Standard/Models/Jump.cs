// <copyright file="Jump.cs" company="APIMatic">
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
    /// Jump.
    /// </summary>
    public class Jump
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Jump"/> class.
        /// </summary>
        public Jump()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Jump"/> class.
        /// </summary>
        /// <param name="shipSymbol">shipSymbol.</param>
        /// <param name="destination">destination.</param>
        public Jump(
            string shipSymbol,
            string destination)
        {
            this.ShipSymbol = shipSymbol;
            this.Destination = destination;
        }

        /// <summary>
        /// Gets or sets ShipSymbol.
        /// </summary>
        [JsonProperty("shipSymbol")]
        public string ShipSymbol { get; set; }

        /// <summary>
        /// Gets or sets Destination.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Jump : ({string.Join(", ", toStringOutput)})";
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

            return obj is Jump other &&
                ((this.ShipSymbol == null && other.ShipSymbol == null) || (this.ShipSymbol?.Equals(other.ShipSymbol) == true)) &&
                ((this.Destination == null && other.Destination == null) || (this.Destination?.Equals(other.Destination) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ShipSymbol = {(this.ShipSymbol == null ? "null" : this.ShipSymbol == string.Empty ? "" : this.ShipSymbol)}");
            toStringOutput.Add($"this.Destination = {(this.Destination == null ? "null" : this.Destination == string.Empty ? "" : this.Destination)}");
        }
    }
}