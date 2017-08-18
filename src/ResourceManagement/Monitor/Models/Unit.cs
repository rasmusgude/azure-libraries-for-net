// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Fluent.ServiceBus.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Fluent;
    using Microsoft.Azure.Management.Fluent.ServiceBus;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for Unit.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Unit
    {
        [EnumMember(Value = "Count")]
        Count,
        [EnumMember(Value = "Bytes")]
        Bytes,
        [EnumMember(Value = "Seconds")]
        Seconds,
        [EnumMember(Value = "CountPerSecond")]
        CountPerSecond,
        [EnumMember(Value = "BytesPerSecond")]
        BytesPerSecond,
        [EnumMember(Value = "Percent")]
        Percent,
        [EnumMember(Value = "MilliSeconds")]
        MilliSeconds
    }
    internal static class UnitEnumExtension
    {
        internal static string ToSerializedValue(this Unit? value)  =>
            value == null ? null : ((Unit)value).ToSerializedValue();

        internal static string ToSerializedValue(this Unit value)
        {
            switch( value )
            {
                case Unit.Count:
                    return "Count";
                case Unit.Bytes:
                    return "Bytes";
                case Unit.Seconds:
                    return "Seconds";
                case Unit.CountPerSecond:
                    return "CountPerSecond";
                case Unit.BytesPerSecond:
                    return "BytesPerSecond";
                case Unit.Percent:
                    return "Percent";
                case Unit.MilliSeconds:
                    return "MilliSeconds";
            }
            return null;
        }

        internal static Unit? ParseUnit(this string value)
        {
            switch( value )
            {
                case "Count":
                    return Unit.Count;
                case "Bytes":
                    return Unit.Bytes;
                case "Seconds":
                    return Unit.Seconds;
                case "CountPerSecond":
                    return Unit.CountPerSecond;
                case "BytesPerSecond":
                    return Unit.BytesPerSecond;
                case "Percent":
                    return Unit.Percent;
                case "MilliSeconds":
                    return Unit.MilliSeconds;
            }
            return null;
        }
    }
}