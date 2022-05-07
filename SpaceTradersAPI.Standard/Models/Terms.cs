// <copyright file="Terms.cs" company="APIMatic">
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
    /// Terms.
    /// </summary>
    public class Terms
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Terms"/> class.
        /// </summary>
        public Terms()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Terms"/> class.
        /// </summary>
        /// <param name="deadline">deadline.</param>
        /// <param name="payment">payment.</param>
        /// <param name="deliver">deliver.</param>
        public Terms(
            string deadline,
            Models.Payment payment,
            List<Models.Deliver> deliver)
        {
            this.Deadline = deadline;
            this.Payment = payment;
            this.Deliver = deliver;
        }

        /// <summary>
        /// Gets or sets Deadline.
        /// </summary>
        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        /// <summary>
        /// Gets or sets Payment.
        /// </summary>
        [JsonProperty("payment")]
        public Models.Payment Payment { get; set; }

        /// <summary>
        /// Gets or sets Deliver.
        /// </summary>
        [JsonProperty("deliver")]
        public List<Models.Deliver> Deliver { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Terms : ({string.Join(", ", toStringOutput)})";
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

            return obj is Terms other &&
                ((this.Deadline == null && other.Deadline == null) || (this.Deadline?.Equals(other.Deadline) == true)) &&
                ((this.Payment == null && other.Payment == null) || (this.Payment?.Equals(other.Payment) == true)) &&
                ((this.Deliver == null && other.Deliver == null) || (this.Deliver?.Equals(other.Deliver) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Deadline = {(this.Deadline == null ? "null" : this.Deadline == string.Empty ? "" : this.Deadline)}");
            toStringOutput.Add($"this.Payment = {(this.Payment == null ? "null" : this.Payment.ToString())}");
            toStringOutput.Add($"this.Deliver = {(this.Deliver == null ? "null" : $"[{string.Join(", ", this.Deliver)} ]")}");
        }
    }
}