// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using SimpleIdServer.Scim.Domains;

namespace SimpleIdServer.Scim.Standard.DTOs
{
    public class ProvisioningConfigurationResult
    {
        public ProvisioningConfigurationResult()
        {
            Records = new List<ProvisioningConfigurationRecordResult>();
        }

        public string Id { get; set; }
        public ProvisioningConfigurationTypes Type { get; set; }
        public string ResourceType { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public ICollection<ProvisioningConfigurationRecordResult> Records { get; set; }

        public static ProvisioningConfigurationResult ToDto(ProvisioningConfiguration provisioning)
        {
            return new ProvisioningConfigurationResult
            {
                Id = provisioning.Id,
                ResourceType = provisioning.ResourceType,
                Type = provisioning.Type,
                UpdateDateTime = provisioning.UpdateDateTime,
                Records = provisioning.Records.Select(r => ProvisioningConfigurationRecordResult.ToDto(r)).ToList()
            };
        }
    }
}
