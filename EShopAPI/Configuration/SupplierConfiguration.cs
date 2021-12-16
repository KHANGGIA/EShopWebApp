using EShopAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShopAPI.Configuration
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable("Suppliers");
            builder.HasKey(x => x.SupplierID);
            builder.Property(x => x.SupplierID).UseIdentityColumn();
            builder.Property(x => x.PhoneNo).IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.HasOne(x => x.Payment).WithMany(x => x.Suppliers).HasForeignKey(x => x.PaymentID);
        }
    }
}
