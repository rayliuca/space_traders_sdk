// <copyright file="MyShipsDeliverResponse.cs" company="APIMatic">
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
    /// MyShipsDeliverResponse.
    /// </summary>
    public class MyShipsDeliverResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyShipsDeliverResponse"/> class.
        /// </summary>
        public MyShipsDeliverResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyShipsDeliverResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public MyShipsDeliverResponse(
            Models.ContractDelivery data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public Models.ContractDelivery Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MyShipsDeliverResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is MyShipsDeliverResponse other &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}