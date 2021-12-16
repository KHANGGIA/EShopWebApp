using EShopAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShopAPI.Configuration
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.ToTable("Blogs");
            builder.HasKey(x => x.PostID);
            builder.Property(x => x.View).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Tag).IsRequired().HasMaxLength(50);
        }
    }
}
