using System;
using System.Threading;
using System.Threading.Tasks;

namespace Subsetting.Domain
{
    public interface IUnitOfWork : IDisposable
    {        
        Task<int> Migrate(CancellationToken cancellationToken = default(CancellationToken));
    }
}