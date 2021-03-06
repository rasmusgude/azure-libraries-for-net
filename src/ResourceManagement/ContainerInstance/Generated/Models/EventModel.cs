// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerInstance.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A container group or container instance event.
    /// </summary>
    public partial class EventModel
    {
        /// <summary>
        /// Initializes a new instance of the EventModel class.
        /// </summary>
        public EventModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventModel class.
        /// </summary>
        /// <param name="count">The count of the event.</param>
        /// <param name="firstTimestamp">The date-time of the earliest logged
        /// event.</param>
        /// <param name="lastTimestamp">The date-time of the latest logged
        /// event.</param>
        /// <param name="name">The event name.</param>
        /// <param name="message">The event message.</param>
        /// <param name="type">The event type.</param>
        public EventModel(int? count = default(int?), System.DateTime? firstTimestamp = default(System.DateTime?), System.DateTime? lastTimestamp = default(System.DateTime?), string name = default(string), string message = default(string), string type = default(string))
        {
            Count = count;
            FirstTimestamp = firstTimestamp;
            LastTimestamp = lastTimestamp;
            Name = name;
            Message = message;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the count of the event.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; private set; }

        /// <summary>
        /// Gets the date-time of the earliest logged event.
        /// </summary>
        [JsonProperty(PropertyName = "firstTimestamp")]
        public System.DateTime? FirstTimestamp { get; private set; }

        /// <summary>
        /// Gets the date-time of the latest logged event.
        /// </summary>
        [JsonProperty(PropertyName = "lastTimestamp")]
        public System.DateTime? LastTimestamp { get; private set; }

        /// <summary>
        /// Gets the event name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the event message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets the event type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
