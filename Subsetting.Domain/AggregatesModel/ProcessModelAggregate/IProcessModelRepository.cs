namespace Subsetting.Domain;

public interface IProcessModelRepository
{
    Task<int> Migrate(CancellationToken cancellationToken = default(CancellationToken));
}