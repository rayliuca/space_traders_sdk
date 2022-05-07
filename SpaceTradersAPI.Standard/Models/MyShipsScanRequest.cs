// <copyright file="MyShipsScanRequest.cs" company="APIMatic">
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
    /// MyShipsScanRequest.
    /// </summary>
    public class MyShipsScanRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyShipsScanRequest"/> class.
        /// </summary>
        public MyShipsScanRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyShipsScanRequest"/> class.
        /// </summary>
        /// <param name="mode">mode.</param>
        public MyShipsScanRequest(
            Models.ModeEnum mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Gets or sets Mode.
        /// </summary>
        [JsonProperty("mode", ItemConverterType = typeof(StringEnumConverter))]
        public Models.ModeEnum Mode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MyShipsScanRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is MyShipsScanRequest other &&
                this.Mode.Equals(other.Mode);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Mode = {this.Mode}");
        }
    }
}