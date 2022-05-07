// <copyright file="MyShipsJumpRequest.cs" company="APIMatic">
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
    /// MyShipsJumpRequest.
    /// </summary>
    public class MyShipsJumpRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyShipsJumpRequest"/> class.
        /// </summary>
        public MyShipsJumpRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyShipsJumpRequest"/> class.
        /// </summary>
        /// <param name="destination">destination.</param>
        public MyShipsJumpRequest(
            string destination = null)
        {
            this.Destination = destination;
        }

        /// <summary>
        /// The system symbol to jump to.
        /// </summary>
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public string Destination { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MyShipsJumpRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is MyShipsJumpRequest other &&
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