using EShopAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShopAPI.Configuration
{
    public class ShipperConfiguration : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.ToTable("Shippers");
            builder.HasKey(x => x.ShipperID);
            builder.Property(x => x.ShipperID).UseIdentityColumn();
            builder.Property(x => x.Phone).IsRequired().IsUnicode(false).HasMaxLength(20);
        }
    }
}
