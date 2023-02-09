namespace Subsetting.Domain;

public class SubsettingConfiguration: Entity, IAggregateRoot
{
    public ConnectionString SourceConnectionString { get; set; }
    public ConnectionString TargetConnectionString { get; set; }
    public Table StartingTable { get; set; }
    public IEnumerable<Filter> Filters { get; set; }
}