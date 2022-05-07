// <copyright file="ModeEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace SpaceTradersAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using SpaceTradersAPI.Standard;
    using SpaceTradersAPI.Standard.Utilities;

    /// <summary>
    /// ModeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ModeEnum
    {
        /// <summary>
        /// APPROACHINGSHIPS.
        /// </summary>
        [EnumMember(Value = "APPROACHING_SHIPS")]
        APPROACHINGSHIPS,

        /// <summary>
        /// DEPARTINGSHIPS.
        /// </summary>
        [EnumMember(Value = "DEPARTING_SHIPS")]
        DEPARTINGSHIPS,

        /// <summary>
        /// SYSTEM.
        /// </summary>
        [EnumMember(Value = "SYSTEM")]
        SYSTEM,

        /// <summary>
        /// WAYPOINT.
        /// </summary>
        [EnumMember(Value = "WAYPOINT")]
        WAYPOINT
    }
}