namespace Subsetting.Domain;

public class ConnectionString: Entity
{
    public ConnectionStringType Type { get; set; }
}

public enum ConnectionStringType
{
    SqlServer,
    Postgres
}