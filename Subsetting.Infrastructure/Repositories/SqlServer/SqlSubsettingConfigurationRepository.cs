namespace Subsetting.Domain;

public class SqlSubsettingConfigurationRepository : ISubsettingConfigurationRepository
{
    public Task<bool> Load(CancellationToken cancellationToken = default(CancellationToken))
    {
        throw new NotImplementedException();
    }
}