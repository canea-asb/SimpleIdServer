﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleIdServer.IdServer.Services.Seeding.Interfaces
{
    /// <summary>
    /// Defines the method that allows to seed record of an entity.
    /// </summary>
    internal interface ISeederService<TRecord> where TRecord : class
    {
        /// <summary>
        /// Allows to seed record of an entity.
        /// </summary>
        /// <param name="records">Entity records to seed.</param>
        /// <returns></returns>
        Task SeedAsync(IReadOnlyCollection<TRecord> records);
    }
}
