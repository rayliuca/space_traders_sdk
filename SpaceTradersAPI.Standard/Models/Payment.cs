// <copyright file="Payment.cs" company="APIMatic">
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
    /// Payment.
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment"/> class.
        /// </summary>
        public Payment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Payment"/> class.
        /// </summary>
        /// <param name="onAccepted">onAccepted.</param>
        /// <param name="onFulfilled">onFulfilled.</param>
        public Payment(
            int onAccepted,
            int onFulfilled)
        {
            this.OnAccepted = onAccepted;
            this.OnFulfilled = onFulfilled;
        }

        /// <summary>
        /// Gets or sets OnAccepted.
        /// </summary>
        [JsonProperty("onAccepted")]
        public int OnAccepted { get; set; }

        /// <summary>
        /// Gets or sets OnFulfilled.
        /// </summary>
        [JsonProperty("onFulfilled")]
        public int OnFulfilled { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Payment : ({string.Join(", ", toStringOutput)})";
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

            return obj is Payment other &&
                this.OnAccepted.Equals(other.OnAccepted) &&
                this.OnFulfilled.Equals(other.OnFulfilled);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.OnAccepted = {this.OnAccepted}");
            toStringOutput.Add($"this.OnFulfilled = {this.OnFulfilled}");
        }
    }
}