// <copyright file="Survey.cs" company="APIMatic">
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
    /// Survey.
    /// </summary>
    public class Survey
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Survey"/> class.
        /// </summary>
        public Survey()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Survey"/> class.
        /// </summary>
        /// <param name="signature">signature.</param>
        /// <param name="deposits">deposits.</param>
        /// <param name="expiration">expiration.</param>
        public Survey(
            string signature,
            List<string> deposits,
            string expiration)
        {
            this.Signature = signature;
            this.Deposits = deposits;
            this.Expiration = expiration;
        }

        /// <summary>
        /// Gets or sets Signature.
        /// </summary>
        [JsonProperty("signature")]
        public string Signature { get; set; }

        /// <summary>
        /// Gets or sets Deposits.
        /// </summary>
        [JsonProperty("deposits")]
        public List<string> Deposits { get; set; }

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

            return $"Survey : ({string.Join(", ", toStringOutput)})";
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

            return obj is Survey other &&
                ((this.Signature == null && other.Signature == null) || (this.Signature?.Equals(other.Signature) == true)) &&
                ((this.Deposits == null && other.Deposits == null) || (this.Deposits?.Equals(other.Deposits) == true)) &&
                ((this.Expiration == null && other.Expiration == null) || (this.Expiration?.Equals(other.Expiration) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Signature = {(this.Signature == null ? "null" : this.Signature == string.Empty ? "" : this.Signature)}");
            toStringOutput.Add($"this.Deposits = {(this.Deposits == null ? "null" : $"[{string.Join(", ", this.Deposits)} ]")}");
            toStringOutput.Add($"this.Expiration = {(this.Expiration == null ? "null" : this.Expiration == string.Empty ? "" : this.Expiration)}");
        }
    }
}