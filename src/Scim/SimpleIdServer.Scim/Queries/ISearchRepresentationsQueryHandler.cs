﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using SimpleIdServer.Scim.Infrastructure;
using SimpleIdServer.Scim.Persistence;
using System.Threading;
using System.Threading.Tasks;
using SimpleIdServer.Scim.Standard.DTOs;

namespace SimpleIdServer.Scim.Queries
{
    public interface ISearchRepresentationsQueryHandler
    {
        Task<GenericResult<SearchSCIMRepresentationsResponse>> Handle(string realm, SearchSCIMResourceParameter searchRequest, string resourceType, CancellationToken cancellationToken);
    }
}
