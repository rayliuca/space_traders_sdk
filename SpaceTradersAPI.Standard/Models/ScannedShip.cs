// <copyright file="ScannedShip.cs" company="APIMatic">
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
    /// ScannedShip.
    /// </summary>
    public class ScannedShip
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScannedShip"/> class.
        /// </summary>
        public ScannedShip()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScannedShip"/> class.
        /// </summary>
        /// <param name="symbol">symbol.</param>
        /// <param name="registration">registration.</param>
        /// <param name="frameSymbol">frameSymbol.</param>
        /// <param name="reactorSymbol">reactorSymbol.</param>
        /// <param name="engineSymbol">engineSymbol.</param>
        /// <param name="expiration">expiration.</param>
        public ScannedShip(
            string symbol,
            Models.Registration registration,
            string frameSymbol,
            string reactorSymbol,
            string engineSymbol,
            string expiration)
        {
            this.Symbol = symbol;
            this.Registration = registration;
            this.FrameSymbol = frameSymbol;
            this.ReactorSymbol = reactorSymbol;
            this.EngineSymbol = engineSymbol;
            this.Expiration = expiration;
        }

        /// <summary>
        /// Gets or sets Symbol.
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets Registration.
        /// </summary>
        [JsonProperty("registration")]
        public Models.Registration Registration { get; set; }

        /// <summary>
        /// Gets or sets FrameSymbol.
        /// </summary>
        [JsonProperty("frameSymbol")]
        public string FrameSymbol { get; set; }

        /// <summary>
        /// Gets or sets ReactorSymbol.
        /// </summary>
        [JsonProperty("reactorSymbol")]
        public string ReactorSymbol { get; set; }

        /// <summary>
        /// Gets or sets EngineSymbol.
        /// </summary>
        [JsonProperty("engineSymbol")]
        public string EngineSymbol { get; set; }

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

            return $"ScannedShip : ({string.Join(", ", toStringOutput)})";
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

            return obj is ScannedShip other &&
                ((this.Symbol == null && other.Symbol == null) || (this.Symbol?.Equals(other.Symbol) == true)) &&
                ((this.Registration == null && other.Registration == null) || (this.Registration?.Equals(other.Registration) == true)) &&
                ((this.FrameSymbol == null && other.FrameSymbol == null) || (this.FrameSymbol?.Equals(other.FrameSymbol) == true)) &&
                ((this.ReactorSymbol == null && other.ReactorSymbol == null) || (this.ReactorSymbol?.Equals(other.ReactorSymbol) == true)) &&
                ((this.EngineSymbol == null && other.EngineSymbol == null) || (this.EngineSymbol?.Equals(other.EngineSymbol) == true)) &&
                ((this.Expiration == null && other.Expiration == null) || (this.Expiration?.Equals(other.Expiration) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Symbol = {(this.Symbol == null ? "null" : this.Symbol == string.Empty ? "" : this.Symbol)}");
            toStringOutput.Add($"this.Registration = {(this.Registration == null ? "null" : this.Registration.ToString())}");
            toStringOutput.Add($"this.FrameSymbol = {(this.FrameSymbol == null ? "null" : this.FrameSymbol == string.Empty ? "" : this.FrameSymbol)}");
            toStringOutput.Add($"this.ReactorSymbol = {(this.ReactorSymbol == null ? "null" : this.ReactorSymbol == string.Empty ? "" : this.ReactorSymbol)}");
            toStringOutput.Add($"this.EngineSymbol = {(this.EngineSymbol == null ? "null" : this.EngineSymbol == string.Empty ? "" : this.EngineSymbol)}");
            toStringOutput.Add($"this.Expiration = {(this.Expiration == null ? "null" : this.Expiration == string.Empty ? "" : this.Expiration)}");
        }
    }
}