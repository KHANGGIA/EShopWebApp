using EShopAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShopAPI.Configuration
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Languages");
            builder.HasKey(x => x.LanguageID);
            builder.Property(x => x.LanguageID).IsRequired().IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);
        }
    }
}
