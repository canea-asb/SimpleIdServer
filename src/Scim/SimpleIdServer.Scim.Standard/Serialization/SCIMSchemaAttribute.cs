﻿using System;
using System.Collections.Generic;

namespace SimpleIdServer.Scim.Standard.Serialization
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SCIMSchemaAttribute : Attribute
    {
        public SCIMSchemaAttribute(params string[] schemas)
        {
            Schemas = schemas;
        }

        public IEnumerable<string> Schemas { get; }
    }
}
