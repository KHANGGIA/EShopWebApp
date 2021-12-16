using EShopAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedObject.Common;

namespace EShopAPI.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x => x.CategoryID);
            builder.Property(x => x.CategoryID).UseIdentityColumn();
            builder.Property(x => x.Published).HasDefaultValue(Status.Active);

        }
    }
}
