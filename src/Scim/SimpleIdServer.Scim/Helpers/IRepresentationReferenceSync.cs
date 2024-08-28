// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.Scim.Domains;
using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleIdServer.Scim.Standard.DTOs;

namespace SimpleIdServer.Scim.Helpers
{
    public interface IRepresentationReferenceSync
    {
        Task<List<RepresentationSyncResult>> Sync(string resourceType, SCIMRepresentation newSourceScimRepresentation, ICollection<SCIMPatchResult> patchOperations, string location, SCIMSchema schema, bool updateAllReference = false);
        Task<bool> IsReferenceProperty(ICollection<string> attributes);
    }
}
