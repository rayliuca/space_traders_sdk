// <copyright file="Faction.cs" company="APIMatic">
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
    /// Faction.
    /// </summary>
    public class Faction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Faction"/> class.
        /// </summary>
        public Faction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Faction"/> class.
        /// </summary>
        /// <param name="symbol">symbol.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="headquarters">headquarters.</param>
        /// <param name="traits">traits.</param>
        public Faction(
            string symbol,
            string name,
            string description,
            string headquarters,
            List<string> traits)
        {
            this.Symbol = symbol;
            this.Name = name;
            this.Description = description;
            this.Headquarters = headquarters;
            this.Traits = traits;
        }

        /// <summary>
        /// Gets or sets Symbol.
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Headquarters.
        /// </summary>
        [JsonProperty("headquarters")]
        public string Headquarters { get; set; }

        /// <summary>
        /// Gets or sets Traits.
        /// </summary>
        [JsonProperty("traits")]
        public List<string> Traits { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Faction : ({string.Join(", ", toStringOutput)})";
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

            return obj is Faction other &&
                ((this.Symbol == null && other.Symbol == null) || (this.Symbol?.Equals(other.Symbol) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Headquarters == null && other.Headquarters == null) || (this.Headquarters?.Equals(other.Headquarters) == true)) &&
                ((this.Traits == null && other.Traits == null) || (this.Traits?.Equals(other.Traits) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Symbol = {(this.Symbol == null ? "null" : this.Symbol == string.Empty ? "" : this.Symbol)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Headquarters = {(this.Headquarters == null ? "null" : this.Headquarters == string.Empty ? "" : this.Headquarters)}");
            toStringOutput.Add($"this.Traits = {(this.Traits == null ? "null" : $"[{string.Join(", ", this.Traits)} ]")}");
        }
    }
}