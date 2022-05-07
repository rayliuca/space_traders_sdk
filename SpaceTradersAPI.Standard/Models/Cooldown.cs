// <copyright file="Cooldown.cs" company="APIMatic">
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
    /// Cooldown.
    /// </summary>
    public class Cooldown
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cooldown"/> class.
        /// </summary>
        public Cooldown()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cooldown"/> class.
        /// </summary>
        /// <param name="duration">duration.</param>
        /// <param name="expiration">expiration.</param>
        public Cooldown(
            int duration,
            string expiration)
        {
            this.Duration = duration;
            this.Expiration = expiration;
        }

        /// <summary>
        /// Gets or sets Duration.
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// Gets or sets Expiration.
        /// </summary>
        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Cooldown : ({string.Join(", ", toStringOutput)})";
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

            return obj is Cooldown other &&
                this.Duration.Equals(other.Duration) &&
                ((this.Expiration == null && other.Expiration == null) || (this.Expiration?.Equals(other.Expiration) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Duration = {this.Duration}");
            toStringOutput.Add($"this.Expiration = {(this.Expiration == null ? "null" : this.Expiration == string.Empty ? "" : this.Expiration)}");
        }
    }
}