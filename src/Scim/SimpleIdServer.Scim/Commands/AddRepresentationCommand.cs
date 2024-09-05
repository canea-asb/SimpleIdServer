﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.Scim.Domains;
using SimpleIdServer.Scim.Infrastructure;
using SimpleIdServer.Scim.Standard.DTOs;

namespace SimpleIdServer.Scim.Commands
{
    public class AddRepresentationCommand : ISCIMCommand<SCIMRepresentation>
    {
        public AddRepresentationCommand(string resourceType, RepresentationParameter representation, string location, string realm)
        {
            ResourceType = resourceType;
            Representation = representation;
            Location = location;
            Realm = realm;
        }

        public string ResourceType { get; set; }
        public RepresentationParameter Representation { get; }
        public string Location { get; }
        public string Realm { get; set; }
    }
}
