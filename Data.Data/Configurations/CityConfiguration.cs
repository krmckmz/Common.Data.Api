using Data.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Data
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder
                 .HasKey(a => a.Code);
            builder
                .Property(a => a.Code)
                .UseIdentityColumn();

            builder
                .Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.ToTable("Cities");
        }
    }
}
