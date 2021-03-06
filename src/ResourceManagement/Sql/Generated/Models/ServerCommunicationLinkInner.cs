// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Server communication link.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ServerCommunicationLinkInner : ProxyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the ServerCommunicationLinkInner
        /// class.
        /// </summary>
        public ServerCommunicationLinkInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerCommunicationLinkInner
        /// class.
        /// </summary>
        /// <param name="partnerServer">The name of the partner server.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="state">The state.</param>
        /// <param name="location">Communication link location.</param>
        /// <param name="kind">Communication link kind.  This property is used
        /// for Azure Portal metadata.</param>
        public ServerCommunicationLinkInner(string partnerServer, string id = default(string), string name = default(string), string type = default(string), string state = default(string), string location = default(string), string kind = default(string))
            : base(id, name, type)
        {
            State = state;
            PartnerServer = partnerServer;
            Location = location;
            Kind = kind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets or sets the name of the partner server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerServer")]
        public string PartnerServer { get; set; }

        /// <summary>
        /// Gets communication link location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets communication link kind.  This property is used for Azure
        /// Portal metadata.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PartnerServer == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PartnerServer");
            }
        }
    }
}
