// <copyright file="MyContractsResponse.cs" company="APIMatic">
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
    /// MyContractsResponse.
    /// </summary>
    public class MyContractsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyContractsResponse"/> class.
        /// </summary>
        public MyContractsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyContractsResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="meta">meta.</param>
        public MyContractsResponse(
            List<Models.Contract> data,
            Models.Meta meta)
        {
            this.Data = data;
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public List<Models.Contract> Data { get; set; }

        /// <summary>
        /// Gets or sets Meta.
        /// </summary>
        [JsonProperty("meta")]
        public Models.Meta Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MyContractsResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is MyContractsResponse other &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Meta == null && other.Meta == null) || (this.Meta?.Equals(other.Meta) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
            toStringOutput.Add($"this.Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");
        }
    }
}