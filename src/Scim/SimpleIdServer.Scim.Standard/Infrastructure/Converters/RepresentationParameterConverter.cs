﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SimpleIdServer.Scim.Domains;
using SimpleIdServer.Scim.Standard.DTOs;
using SimpleIdServer.Scim.Standard.Extensions;

namespace SimpleIdServer.Scim.Standard.Infrastructure.Converters
{
    public class RepresentationParameterConverter : JsonConverter
    {
        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType)
        {
            return objectType.GetTypeInfo().Equals(typeof(RepresentationParameter).GetTypeInfo());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jo = JObject.Load(reader);
            var result = new RepresentationParameter
            {
                ExternalId = jo.GetStringIgnoreCase(StandardSCIMRepresentationAttributes.ExternalId),
                Schemas = jo.GetArrayIgnoreCase(StandardSCIMRepresentationAttributes.Schemas)
            };
            result.Attributes = jo.ToCamelCase() as JObject;
            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => throw new NotImplementedException();
    }
}
