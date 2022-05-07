// <copyright file="Data6.cs" company="APIMatic">
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
    /// Data6.
    /// </summary>
    public class Data6
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data6"/> class.
        /// </summary>
        public Data6()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data6"/> class.
        /// </summary>
        /// <param name="extraction">extraction.</param>
        /// <param name="cooldown">cooldown.</param>
        public Data6(
            Models.Extraction extraction,
            Models.Cooldown cooldown)
        {
            this.Extraction = extraction;
            this.Cooldown = cooldown;
        }

        /// <summary>
        /// Gets or sets Extraction.
        /// </summary>
        [JsonProperty("extraction")]
        public Models.Extraction Extraction { get; set; }

        /// <summary>
        /// Gets or sets Cooldown.
        /// </summary>
        [JsonProperty("cooldown")]
        public Models.Cooldown Cooldown { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data6 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data6 other &&
                ((this.Extraction == null && other.Extraction == null) || (this.Extraction?.Equals(other.Extraction) == true)) &&
                ((this.Cooldown == null && other.Cooldown == null) || (this.Cooldown?.Equals(other.Cooldown) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Extraction = {(this.Extraction == null ? "null" : this.Extraction.ToString())}");
            toStringOutput.Add($"this.Cooldown = {(this.Cooldown == null ? "null" : this.Cooldown.ToString())}");
        }
    }
}