namespace Subsetting.Domain;

public interface ISubsettingConfigurationRepository
{
    Task<bool> Load(CancellationToken cancellationToken = default(CancellationToken));
}