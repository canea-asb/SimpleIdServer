﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SimpleIdServer.Scim.Domains;
using SimpleIdServer.Scim.Standard.Infrastructure.Converters;

namespace SimpleIdServer.Scim.Standard.DTOs
{
    [JsonConverter(typeof(RepresentationParameterConverter))]
    public class RepresentationParameter : BaseParameter
    {
        public RepresentationParameter() : base()
        {

        }

        /// <summary>
        ///  A String that is an identifier for the resource as defined by the provisioning client.
        /// </summary>
        [JsonProperty(StandardSCIMRepresentationAttributes.ExternalId)]
        public string ExternalId { get; set; }
        [JsonIgnore]
        public JObject Attributes { get; set; }
    }
}