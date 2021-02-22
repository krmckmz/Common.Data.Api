using Data.Core;
using Microsoft.EntityFrameworkCore;

namespace Data.Data
{
    public class DataDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }

        public DataDbContext(DbContextOptions<DataDbContext> options) 
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new CityConfiguration());
        }
    }
}
