using System;
using System.Collections.Generic;
using System.Text;

namespace NeoClient.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Class)]
    public class NodeAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
