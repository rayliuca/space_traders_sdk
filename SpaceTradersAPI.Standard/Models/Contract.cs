// <copyright file="Contract.cs" company="APIMatic">
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
    /// Contract.
    /// </summary>
    public class Contract
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contract"/> class.
        /// </summary>
        public Contract()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contract"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="faction">faction.</param>
        /// <param name="type">type.</param>
        /// <param name="terms">terms.</param>
        /// <param name="accepted">accepted.</param>
        /// <param name="fulfilled">fulfilled.</param>
        /// <param name="expiresAt">expiresAt.</param>
        public Contract(
            string id,
            string faction,
            string type,
            Models.Terms terms,
            bool accepted,
            bool fulfilled,
            string expiresAt)
        {
            this.Id = id;
            this.Faction = faction;
            this.Type = type;
            this.Terms = terms;
            this.Accepted = accepted;
            this.Fulfilled = fulfilled;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Faction.
        /// </summary>
        [JsonProperty("faction")]
        public string Faction { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Terms.
        /// </summary>
        [JsonProperty("terms")]
        public Models.Terms Terms { get; set; }

        /// <summary>
        /// Gets or sets Accepted.
        /// </summary>
        [JsonProperty("accepted")]
        public bool Accepted { get; set; }

        /// <summary>
        /// Gets or sets Fulfilled.
        /// </summary>
        [JsonProperty("fulfilled")]
        public bool Fulfilled { get; set; }

        /// <summary>
        /// Gets or sets ExpiresAt.
        /// </summary>
        [JsonProperty("expiresAt")]
        public string ExpiresAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Contract : ({string.Join(", ", toStringOutput)})";
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

            return obj is Contract other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Faction == null && other.Faction == null) || (this.Faction?.Equals(other.Faction) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Terms == null && other.Terms == null) || (this.Terms?.Equals(other.Terms) == true)) &&
                this.Accepted.Equals(other.Accepted) &&
                this.Fulfilled.Equals(other.Fulfilled) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Faction = {(this.Faction == null ? "null" : this.Faction == string.Empty ? "" : this.Faction)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Terms = {(this.Terms == null ? "null" : this.Terms.ToString())}");
            toStringOutput.Add($"this.Accepted = {this.Accepted}");
            toStringOutput.Add($"this.Fulfilled = {this.Fulfilled}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt == string.Empty ? "" : this.ExpiresAt)}");
        }
    }
}