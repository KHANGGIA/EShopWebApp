using EShopAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShopAPI.Configuration
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("Locations");
            builder.HasKey(x => x.LocationID);
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.NameWithType).HasMaxLength(100);
        }
    }
}
