using System;

namespace SimpleIdServer.Scim.Standard.Serialization
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SCIMSchemaPropertyAttribute : Attribute
    {
        public SCIMSchemaPropertyAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
