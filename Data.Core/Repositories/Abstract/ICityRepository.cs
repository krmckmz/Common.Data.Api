using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Core
{
    public interface ICityRepository : IRepository<City>
    {
        Task<IEnumerable<City>> GetAllCitiesAsync();
    }
}
