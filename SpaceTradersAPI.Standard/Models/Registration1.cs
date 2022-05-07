// <copyright file="Registration1.cs" company="APIMatic">
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
    /// Registration1.
    /// </summary>
    public class Registration1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Registration1"/> class.
        /// </summary>
        public Registration1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Registration1"/> class.
        /// </summary>
        /// <param name="factionSymbol">factionSymbol.</param>
        /// <param name="agentSymbol">agentSymbol.</param>
        /// <param name="fee">fee.</param>
        /// <param name="role">role.</param>
        public Registration1(
            string factionSymbol,
            string agentSymbol,
            int fee,
            string role)
        {
            this.FactionSymbol = factionSymbol;
            this.AgentSymbol = agentSymbol;
            this.Fee = fee;
            this.Role = role;
        }

        /// <summary>
        /// Gets or sets FactionSymbol.
        /// </summary>
        [JsonProperty("factionSymbol")]
        public string FactionSymbol { get; set; }

        /// <summary>
        /// Gets or sets AgentSymbol.
        /// </summary>
        [JsonProperty("agentSymbol")]
        public string AgentSymbol { get; set; }

        /// <summary>
        /// Gets or sets Fee.
        /// </summary>
        [JsonProperty("fee")]
        public int Fee { get; set; }

        /// <summary>
        /// Gets or sets Role.
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Registration1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Registration1 other &&
                ((this.FactionSymbol == null && other.FactionSymbol == null) || (this.FactionSymbol?.Equals(other.FactionSymbol) == true)) &&
                ((this.AgentSymbol == null && other.AgentSymbol == null) || (this.AgentSymbol?.Equals(other.AgentSymbol) == true)) &&
                this.Fee.Equals(other.Fee) &&
                ((this.Role == null && other.Role == null) || (this.Role?.Equals(other.Role) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FactionSymbol = {(this.FactionSymbol == null ? "null" : this.FactionSymbol == string.Empty ? "" : this.FactionSymbol)}");
            toStringOutput.Add($"this.AgentSymbol = {(this.AgentSymbol == null ? "null" : this.AgentSymbol == string.Empty ? "" : this.AgentSymbol)}");
            toStringOutput.Add($"this.Fee = {this.Fee}");
            toStringOutput.Add($"this.Role = {(this.Role == null ? "null" : this.Role == string.Empty ? "" : this.Role)}");
        }
    }
}