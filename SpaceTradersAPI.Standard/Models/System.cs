// <copyright file="System.cs" company="APIMatic">
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
    /// System.
    /// </summary>
    public class System
    {
        private string chartedBy;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "chartedBy", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="System"/> class.
        /// </summary>
        public System()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="System"/> class.
        /// </summary>
        /// <param name="symbol">symbol.</param>
        /// <param name="sector">sector.</param>
        /// <param name="type">type.</param>
        /// <param name="x">x.</param>
        /// <param name="y">y.</param>
        /// <param name="waypoints">waypoints.</param>
        /// <param name="factions">factions.</param>
        /// <param name="charted">charted.</param>
        /// <param name="chartedBy">chartedBy.</param>
        public System(
            string symbol,
            string sector,
            string type,
            int x,
            int y,
            List<string> waypoints,
            List<string> factions,
            bool charted,
            string chartedBy = null)
        {
            this.Symbol = symbol;
            this.Sector = sector;
            this.Type = type;
            this.X = x;
            this.Y = y;
            this.Waypoints = waypoints;
            this.Factions = factions;
            this.Charted = charted;
            if (chartedBy != null)
            {
                this.ChartedBy = chartedBy;
            }

        }

        /// <summary>
        /// Gets or sets Symbol.
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets Sector.
        /// </summary>
        [JsonProperty("sector")]
        public string Sector { get; set; }

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
        /// Gets or sets Waypoints.
        /// </summary>
        [JsonProperty("waypoints")]
        public List<string> Waypoints { get; set; }

        /// <summary>
        /// Gets or sets Factions.
        /// </summary>
        [JsonProperty("factions")]
        public List<string> Factions { get; set; }

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

            return $"System : ({string.Join(", ", toStringOutput)})";
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

            return obj is System other &&
                ((this.Symbol == null && other.Symbol == null) || (this.Symbol?.Equals(other.Symbol) == true)) &&
                ((this.Sector == null && other.Sector == null) || (this.Sector?.Equals(other.Sector) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                this.X.Equals(other.X) &&
                this.Y.Equals(other.Y) &&
                ((this.Waypoints == null && other.Waypoints == null) || (this.Waypoints?.Equals(other.Waypoints) == true)) &&
                ((this.Factions == null && other.Factions == null) || (this.Factions?.Equals(other.Factions) == true)) &&
                this.Charted.Equals(other.Charted) &&
                ((this.ChartedBy == null && other.ChartedBy == null) || (this.ChartedBy?.Equals(other.ChartedBy) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Symbol = {(this.Symbol == null ? "null" : this.Symbol == string.Empty ? "" : this.Symbol)}");
            toStringOutput.Add($"this.Sector = {(this.Sector == null ? "null" : this.Sector == string.Empty ? "" : this.Sector)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.X = {this.X}");
            toStringOutput.Add($"this.Y = {this.Y}");
            toStringOutput.Add($"this.Waypoints = {(this.Waypoints == null ? "null" : $"[{string.Join(", ", this.Waypoints)} ]")}");
            toStringOutput.Add($"this.Factions = {(this.Factions == null ? "null" : $"[{string.Join(", ", this.Factions)} ]")}");
            toStringOutput.Add($"this.Charted = {this.Charted}");
            toStringOutput.Add($"this.ChartedBy = {(this.ChartedBy == null ? "null" : this.ChartedBy == string.Empty ? "" : this.ChartedBy)}");
        }
    }
}