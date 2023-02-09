namespace Subsetting.Domain
{
    public class ProcessModel: Entity, IAggregateRoot
    {
        private readonly IEnumerable<Table> _tables;
        public IEnumerable<Table> Tables => _tables;

        private ProcessModel(IEnumerable<Table> tables)
        {
            // Sort tables by an algorithm like Topological sort
            _tables = SortTables(tables);
        }

        private IEnumerable<Table> SortTables(IEnumerable<Table> tables)
        {
            var sortedTables = new List<Table>();
            return sortedTables;
        }

        private static ProcessModel BuildProcessModel(IEnumerable<Table> tables)
        {
            return new ProcessModel(tables);
        }
    }
}