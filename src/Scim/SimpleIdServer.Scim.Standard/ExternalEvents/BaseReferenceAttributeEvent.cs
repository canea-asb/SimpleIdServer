﻿using SimpleIdServer.Scim.Domains;

namespace SimpleIdServer.Scim.Standard.ExternalEvents
{
    public class BaseReferenceAttributeEvent : IntegrationEvent
    {
        public BaseReferenceAttributeEvent()
        {

        }

        public BaseReferenceAttributeEvent(SCIMRepresentationAttribute attribute)
        {
            Attribute = attribute;
        }

        public SCIMRepresentationAttribute Attribute { get; set; }
    }
}
