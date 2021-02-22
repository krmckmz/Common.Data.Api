using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Core
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
    }
}
