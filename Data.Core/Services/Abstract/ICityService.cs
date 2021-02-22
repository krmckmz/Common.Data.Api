using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Core
{
    public interface ICityService
    {
        Task<IEnumerable<City>> GetAllCities();
    }
}
