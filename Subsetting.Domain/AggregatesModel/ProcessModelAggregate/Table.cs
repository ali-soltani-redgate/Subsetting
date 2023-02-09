namespace Subsetting.Domain
{    
    public class Table
    {
        public IEnumerable<Relationship> Relationships { get; }

        public Table(IEnumerable<Relationship> relationships)
        {
            Relationships = relationships;
        }
    }
}