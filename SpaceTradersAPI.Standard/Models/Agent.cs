// <copyright file="Agent.cs" company="APIMatic">
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
    /// Agent.
    /// </summary>
    public class Agent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Agent"/> class.
        /// </summary>
        public Agent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent"/> class.
        /// </summary>
        /// <param name="accountId">accountId.</param>
        /// <param name="symbol">symbol.</param>
        /// <param name="headquarters">headquarters.</param>
        /// <param name="credits">credits.</param>
        public Agent(
            string accountId,
            string symbol,
            string headquarters,
            int credits)
        {
            this.AccountId = accountId;
            this.Symbol = symbol;
            this.Headquarters = headquarters;
            this.Credits = credits;
        }

        /// <summary>
        /// Gets or sets AccountId.
        /// </summary>
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets Symbol.
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets Headquarters.
        /// </summary>
        [JsonProperty("headquarters")]
        public string Headquarters { get; set; }

        /// <summary>
        /// Gets or sets Credits.
        /// </summary>
        [JsonProperty("credits")]
        public int Credits { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Agent : ({string.Join(", ", toStringOutput)})";
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

            return obj is Agent other &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.Symbol == null && other.Symbol == null) || (this.Symbol?.Equals(other.Symbol) == true)) &&
                ((this.Headquarters == null && other.Headquarters == null) || (this.Headquarters?.Equals(other.Headquarters) == true)) &&
                this.Credits.Equals(other.Credits);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId == string.Empty ? "" : this.AccountId)}");
            toStringOutput.Add($"this.Symbol = {(this.Symbol == null ? "null" : this.Symbol == string.Empty ? "" : this.Symbol)}");
            toStringOutput.Add($"this.Headquarters = {(this.Headquarters == null ? "null" : this.Headquarters == string.Empty ? "" : this.Headquarters)}");
            toStringOutput.Add($"this.Credits = {this.Credits}");
        }
    }
}