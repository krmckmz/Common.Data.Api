using Data.Core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Data
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(DataDbContext context)
            : base(context)
        {

        }
        public async Task<IEnumerable<City>> GetAllCitiesAsync()
        {
            return await DataDbContext.Cities.ToListAsync();
        }

        private DataDbContext DataDbContext
        {
            get { return Context as DataDbContext; }
        }
    }
}
