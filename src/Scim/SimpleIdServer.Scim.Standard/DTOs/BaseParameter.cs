// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using SimpleIdServer.Scim.Domains;

namespace SimpleIdServer.Scim.Standard.DTOs
{
    public class BaseParameter
    {
        public BaseParameter()
        {
            Schemas = new List<string>();
        }

        /// <summary>
        /// List of one or more URIs that indicate included SCIM schemas that are used to indicate the attributes contained within a resource.
        /// </summary>
        [DataMember(Name = StandardSCIMRepresentationAttributes.Schemas)]
        [JsonProperty(StandardSCIMRepresentationAttributes.Schemas)]
        public IEnumerable<string> Schemas { get; set; }
    }
}
