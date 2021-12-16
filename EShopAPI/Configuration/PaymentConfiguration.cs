using EShopAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedObject.Common;

namespace EShopAPI.Configuration
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payments");
            builder.HasKey(x => x.PaymentID);
            builder.Property(x => x.PaymentType).HasMaxLength(100);
            builder.Property(x => x.Allowed).HasDefaultValue(Confirm.Yes);
        }
    }
}
