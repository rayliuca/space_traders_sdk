// <copyright file="Integrity.cs" company="APIMatic">
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
    /// Integrity.
    /// </summary>
    public class Integrity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Integrity"/> class.
        /// </summary>
        public Integrity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Integrity"/> class.
        /// </summary>
        /// <param name="frame">frame.</param>
        /// <param name="reactor">reactor.</param>
        /// <param name="engine">engine.</param>
        public Integrity(
            double frame,
            double reactor,
            double engine)
        {
            this.Frame = frame;
            this.Reactor = reactor;
            this.Engine = engine;
        }

        /// <summary>
        /// Gets or sets Frame.
        /// </summary>
        [JsonProperty("frame")]
        public double Frame { get; set; }

        /// <summary>
        /// Gets or sets Reactor.
        /// </summary>
        [JsonProperty("reactor")]
        public double Reactor { get; set; }

        /// <summary>
        /// Gets or sets Engine.
        /// </summary>
        [JsonProperty("engine")]
        public double Engine { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Integrity : ({string.Join(", ", toStringOutput)})";
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

            return obj is Integrity other &&
                this.Frame.Equals(other.Frame) &&
                this.Reactor.Equals(other.Reactor) &&
                this.Engine.Equals(other.Engine);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Frame = {this.Frame}");
            toStringOutput.Add($"this.Reactor = {this.Reactor}");
            toStringOutput.Add($"this.Engine = {this.Engine}");
        }
    }
}