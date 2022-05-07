// <copyright file="Waypoint.cs" company="APIMatic">
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
    /// Waypoint.
    /// </summary>
    public class Waypoint
    {
        private string chartedBy;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "chartedBy", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Waypoint"/> class.
        /// </summary>
        public Waypoint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Waypoint"/> class.
        /// </summary>
        /// <param name="system">system.</param>
        /// <param name="symbol">symbol.</param>
        /// <param name="type">type.</param>
        /// <param name="x">x.</param>
        /// <param name="y">y.</param>
        /// <param name="orbitals">orbitals.</param>
        /// <param name="faction">faction.</param>
        /// <param name="features">features.</param>
        /// <param name="traits">traits.</param>
        /// <param name="charted">charted.</param>
        /// <param name="chartedBy">chartedBy.</param>
        public Waypoint(
            string system,
            string symbol,
            string type,
            int x,
            int y,
            List<string> orbitals,
            string faction,
            List<string> features,
            List<string> traits,
            bool charted,
            string chartedBy = null)
        {
            this.System = system;
            this.Symbol = symbol;
            this.Type = type;
            this.X = x;
            this.Y = y;
            this.Orbitals = orbitals;
            this.Faction = faction;
            this.Features = features;
            this.Traits = traits;
            this.Charted = charted;
            if (chartedBy != null)
            {
                this.ChartedBy = chartedBy;
            }

        }

        /// <summary>
        /// Gets or sets System.
        /// </summary>
        [JsonProperty("system")]
        public string System { get; set; }

        /// <summary>
        /// Gets or sets Symbol.
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets X.
        /// </summary>
        [JsonProperty("x")]
        public int X { get; set; }

        /// <summary>
        /// Gets or sets Y.
        /// </summary>
        [JsonProperty("y")]
        public int Y { get; set; }

        /// <summary>
        /// Gets or sets Orbitals.
        /// </summary>
        [JsonProperty("orbitals")]
        public List<string> Orbitals { get; set; }

        /// <summary>
        /// Gets or sets Faction.
        /// </summary>
        [JsonProperty("faction")]
        public string Faction { get; set; }

        /// <summary>
        /// Gets or sets Features.
        /// </summary>
        [JsonProperty("features")]
        public List<string> Features { get; set; }

        /// <summary>
        /// Gets or sets Traits.
        /// </summary>
        [JsonProperty("traits")]
        public List<string> Traits { get; set; }

        /// <summary>
        /// Gets or sets Charted.
        /// </summary>
        [JsonProperty("charted")]
        public bool Charted { get; set; }

        /// <summary>
        /// Gets or sets ChartedBy.
        /// </summary>
        [JsonProperty("chartedBy")]
        public string ChartedBy
        {
            get
            {
                return this.chartedBy;
            }

            set
            {
                this.shouldSerialize["chartedBy"] = true;
                this.chartedBy = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Waypoint : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetChartedBy()
        {
            this.shouldSerialize["chartedBy"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChartedBy()
        {
            return this.shouldSerialize["chartedBy"];
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

            return obj is Waypoint other &&
                ((this.System == null && other.System == null) || (this.System?.Equals(other.System) == true)) &&
                ((this.Symbol == null && other.Symbol == null) || (this.Symbol?.Equals(other.Symbol) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                this.X.Equals(other.X) &&
                this.Y.Equals(other.Y) &&
                ((this.Orbitals == null && other.Orbitals == null) || (this.Orbitals?.Equals(other.Orbitals) == true)) &&
                ((this.Faction == null && other.Faction == null) || (this.Faction?.Equals(other.Faction) == true)) &&
                ((this.Features == null && other.Features == null) || (this.Features?.Equals(other.Features) == true)) &&
                ((this.Traits == null && other.Traits == null) || (this.Traits?.Equals(other.Traits) == true)) &&
                this.Charted.Equals(other.Charted) &&
                ((this.ChartedBy == null && other.ChartedBy == null) || (this.ChartedBy?.Equals(other.ChartedBy) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.System = {(this.System == null ? "null" : this.System == string.Empty ? "" : this.System)}");
            toStringOutput.Add($"this.Symbol = {(this.Symbol == null ? "null" : this.Symbol == string.Empty ? "" : this.Symbol)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.X = {this.X}");
            toStringOutput.Add($"this.Y = {this.Y}");
            toStringOutput.Add($"this.Orbitals = {(this.Orbitals == null ? "null" : $"[{string.Join(", ", this.Orbitals)} ]")}");
            toStringOutput.Add($"this.Faction = {(this.Faction == null ? "null" : this.Faction == string.Empty ? "" : this.Faction)}");
            toStringOutput.Add($"this.Features = {(this.Features == null ? "null" : $"[{string.Join(", ", this.Features)} ]")}");
            toStringOutput.Add($"this.Traits = {(this.Traits == null ? "null" : $"[{string.Join(", ", this.Traits)} ]")}");
            toStringOutput.Add($"this.Charted = {this.Charted}");
            toStringOutput.Add($"this.ChartedBy = {(this.ChartedBy == null ? "null" : this.ChartedBy == string.Empty ? "" : this.ChartedBy)}");
        }
    }
}