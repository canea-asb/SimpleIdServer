﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using System.Collections.Generic;

namespace SimpleIdServer.IdServer.DTOs.Seeds
{
    /// <summary>
    /// Represents all the entities to seed.
    /// </summary>
    internal class SeedsDto
    {

        public IReadOnlyCollection<UserSeedDto> Users { get; set; } = [];
    }
}
