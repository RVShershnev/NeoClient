namespace NeoClient
{
    public class EntityBase : IEntityBase
    {
        public EntityBase(string label)
        {
            Label = label;
        }

        public string Label { get; set; }
        public string Uuid { get; set; }
        public bool IsDeleted { get; set; }
    }
}