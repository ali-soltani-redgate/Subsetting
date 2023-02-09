namespace Subsetting.Domain
{    
    public class Relationship: Entity
    {
        private Table Parent { get; }
        private Table Child { get; }

        public Relationship(Table parent, Table child)
        {
            Parent = parent;
            Child = child;
        }
    }
}