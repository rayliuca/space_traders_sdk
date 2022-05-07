// <copyright file="Data8.cs" company="APIMatic">
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
    /// Data8.
    /// </summary>
    public class Data8
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data8"/> class.
        /// </summary>
        public Data8()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data8"/> class.
        /// </summary>
        /// <param name="surveys">surveys.</param>
        /// <param name="cooldown">cooldown.</param>
        public Data8(
            List<Models.Survey> surveys = null,
            Models.Cooldown cooldown = null)
        {
            this.Surveys = surveys;
            this.Cooldown = cooldown;
        }

        /// <summary>
        /// Gets or sets Surveys.
        /// </summary>
        [JsonProperty("surveys", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Survey> Surveys { get; set; }

        /// <summary>
        /// Gets or sets Cooldown.
        /// </summary>
        [JsonProperty("cooldown", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Cooldown Cooldown { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data8 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data8 other &&
                ((this.Surveys == null && other.Surveys == null) || (this.Surveys?.Equals(other.Surveys) == true)) &&
                ((this.Cooldown == null && other.Cooldown == null) || (this.Cooldown?.Equals(other.Cooldown) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Surveys = {(this.Surveys == null ? "null" : $"[{string.Join(", ", this.Surveys)} ]")}");
            toStringOutput.Add($"this.Cooldown = {(this.Cooldown == null ? "null" : this.Cooldown.ToString())}");
        }
    }
}