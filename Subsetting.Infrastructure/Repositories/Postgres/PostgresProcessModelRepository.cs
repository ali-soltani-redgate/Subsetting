using Subsetting.Domain;

namespace Subsetting.Infrastructure;

public class PostgresProcessModelRepository : IProcessModelRepository
{
    public Task<int> Migrate(CancellationToken cancellationToken = default(CancellationToken))
    {
        throw new NotImplementedException();
    }
}