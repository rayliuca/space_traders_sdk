// <copyright file="MyShipsExtractRequest.cs" company="APIMatic">
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
    /// MyShipsExtractRequest.
    /// </summary>
    public class MyShipsExtractRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyShipsExtractRequest"/> class.
        /// </summary>
        public MyShipsExtractRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyShipsExtractRequest"/> class.
        /// </summary>
        /// <param name="survey">survey.</param>
        public MyShipsExtractRequest(
            Models.Survey survey = null)
        {
            this.Survey = survey;
        }

        /// <summary>
        /// Gets or sets Survey.
        /// </summary>
        [JsonProperty("survey", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Survey Survey { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MyShipsExtractRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is MyShipsExtractRequest other &&
                ((this.Survey == null && other.Survey == null) || (this.Survey?.Equals(other.Survey) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Survey = {(this.Survey == null ? "null" : this.Survey.ToString())}");
        }
    }
}