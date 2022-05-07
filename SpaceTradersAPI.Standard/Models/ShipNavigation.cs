// <copyright file="ShipNavigation.cs" company="APIMatic">
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
    /// ShipNavigation.
    /// </summary>
    public class ShipNavigation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipNavigation"/> class.
        /// </summary>
        public ShipNavigation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipNavigation"/> class.
        /// </summary>
        /// <param name="shipSymbol">shipSymbol.</param>
        /// <param name="departure">departure.</param>
        /// <param name="destination">destination.</param>
        /// <param name="durationRemaining">durationRemaining.</param>
        /// <param name="arrivedAt">arrivedAt.</param>
        public ShipNavigation(
            string shipSymbol,
            string departure,
            string destination,
            int durationRemaining,
            object arrivedAt = null)
        {
            this.ShipSymbol = shipSymbol;
            this.Departure = departure;
            this.Destination = destination;
            this.DurationRemaining = durationRemaining;
            this.ArrivedAt = arrivedAt;
        }

        /// <summary>
        /// Gets or sets ShipSymbol.
        /// </summary>
        [JsonProperty("shipSymbol")]
        public string ShipSymbol { get; set; }

        /// <summary>
        /// Gets or sets Departure.
        /// </summary>
        [JsonProperty("departure")]
        public string Departure { get; set; }

        /// <summary>
        /// Gets or sets Destination.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or sets DurationRemaining.
        /// </summary>
        [JsonProperty("durationRemaining")]
        public int DurationRemaining { get; set; }

        /// <summary>
        /// Gets or sets ArrivedAt.
        /// </summary>
        [JsonProperty("arrivedAt", NullValueHandling = NullValueHandling.Ignore)]
        public object ArrivedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ShipNavigation : ({string.Join(", ", toStringOutput)})";
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

            return obj is ShipNavigation other &&
                ((this.ShipSymbol == null && other.ShipSymbol == null) || (this.ShipSymbol?.Equals(other.ShipSymbol) == true)) &&
                ((this.Departure == null && other.Departure == null) || (this.Departure?.Equals(other.Departure) == true)) &&
                ((this.Destination == null && other.Destination == null) || (this.Destination?.Equals(other.Destination) == true)) &&
                this.DurationRemaining.Equals(other.DurationRemaining) &&
                ((this.ArrivedAt == null && other.ArrivedAt == null) || (this.ArrivedAt?.Equals(other.ArrivedAt) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ShipSymbol = {(this.ShipSymbol == null ? "null" : this.ShipSymbol == string.Empty ? "" : this.ShipSymbol)}");
            toStringOutput.Add($"this.Departure = {(this.Departure == null ? "null" : this.Departure == string.Empty ? "" : this.Departure)}");
            toStringOutput.Add($"this.Destination = {(this.Destination == null ? "null" : this.Destination == string.Empty ? "" : this.Destination)}");
            toStringOutput.Add($"this.DurationRemaining = {this.DurationRemaining}");
            toStringOutput.Add($"ArrivedAt = {(this.ArrivedAt == null ? "null" : this.ArrivedAt.ToString())}");
        }
    }
}