using System;

namespace NeoClient
{
    public class EntityBase : IEntityBase
    {
        public EntityBase(string label)
        {
            Label = label;
            Uuid = Guid.NewGuid().ToString();
        }

        public EntityBase(string label, string uuid)
        {      
            Label = label;
            Uuid = uuid;
        }

        public string Label { get; set; }
        public virtual string Uuid { get; set; }
        public bool IsDeleted { get; set; }
    }
}