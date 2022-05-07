// <copyright file="Data10.cs" company="APIMatic">
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
    /// Data10.
    /// </summary>
    public class Data10
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data10"/> class.
        /// </summary>
        public Data10()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data10"/> class.
        /// </summary>
        /// <param name="jump">jump.</param>
        /// <param name="cooldown">cooldown.</param>
        public Data10(
            Models.Jump jump,
            Models.Cooldown cooldown)
        {
            this.Jump = jump;
            this.Cooldown = cooldown;
        }

        /// <summary>
        /// Gets or sets Jump.
        /// </summary>
        [JsonProperty("jump")]
        public Models.Jump Jump { get; set; }

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

            return $"Data10 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Data10 other &&
                ((this.Jump == null && other.Jump == null) || (this.Jump?.Equals(other.Jump) == true)) &&
                ((this.Cooldown == null && other.Cooldown == null) || (this.Cooldown?.Equals(other.Cooldown) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Jump = {(this.Jump == null ? "null" : this.Jump.ToString())}");
            toStringOutput.Add($"this.Cooldown = {(this.Cooldown == null ? "null" : this.Cooldown.ToString())}");
        }
    }
}