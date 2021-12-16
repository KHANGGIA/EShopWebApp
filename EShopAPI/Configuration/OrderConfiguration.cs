using EShopAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedObject.Common;

namespace EShopAPI.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.OrderID);
            builder.Property(x => x.OrderID).UseIdentityColumn();
            builder.Property(x => x.Paid).HasDefaultValue(Confirm.Yes);
            builder.Property(x => x.Deleted).HasDefaultValue(Confirm.Yes);
            builder.Property(x => x.OrderDate).HasDefaultValue(DateTime.Now);
        }
    }
}
