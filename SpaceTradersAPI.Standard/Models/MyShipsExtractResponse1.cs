// <copyright file="MyShipsExtractResponse1.cs" company="APIMatic">
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
    /// MyShipsExtractResponse1.
    /// </summary>
    public class MyShipsExtractResponse1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyShipsExtractResponse1"/> class.
        /// </summary>
        public MyShipsExtractResponse1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyShipsExtractResponse1"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public MyShipsExtractResponse1(
            Models.Data7 data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public Models.Data7 Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MyShipsExtractResponse1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is MyShipsExtractResponse1 other &&
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