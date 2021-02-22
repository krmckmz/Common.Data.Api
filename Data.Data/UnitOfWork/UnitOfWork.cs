using Data.Core;
using System.Threading.Tasks;

namespace Data.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataDbContext _context;
        private CityRepository _cityRepository;

        public UnitOfWork(DataDbContext dataDbContext)
        {
            this._context = dataDbContext;
        }
        public ICityRepository Cities => _cityRepository ?? new CityRepository(_context);
        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
