using System;
using System.Threading.Tasks;

namespace Data.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICityRepository Cities { get; }
        Task<int> CommitAsync();
    }
}
