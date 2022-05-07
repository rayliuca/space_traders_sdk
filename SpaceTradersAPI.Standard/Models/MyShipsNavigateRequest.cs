// <copyright file="MyShipsNavigateRequest.cs" company="APIMatic">
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
    /// MyShipsNavigateRequest.
    /// </summary>
    public class MyShipsNavigateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyShipsNavigateRequest"/> class.
        /// </summary>
        public MyShipsNavigateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyShipsNavigateRequest"/> class.
        /// </summary>
        /// <param name="destination">destination.</param>
        public MyShipsNavigateRequest(
            string destination = null)
        {
            this.Destination = destination;
        }

        /// <summary>
        /// The waypoint symbol to navigate to.
        /// </summary>
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public string Destination { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MyShipsNavigateRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is MyShipsNavigateRequest other &&
                ((this.Destination == null && other.Destination == null) || (this.Destination?.Equals(other.Destination) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Destination = {(this.Destination == null ? "null" : this.Destination == string.Empty ? "" : this.Destination)}");
        }
    }
}