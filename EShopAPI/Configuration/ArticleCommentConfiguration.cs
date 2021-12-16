using EShopAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShopAPI.Configuration
{
    public class ArticleCommentConfiguration : IEntityTypeConfiguration<ArticleComment>
    {
        public void Configure(EntityTypeBuilder<ArticleComment> builder)
        {
            builder.ToTable("ArticleComments");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).UseIdentityColumn();
            builder.HasOne(x => x.Article).WithMany(x => x.ArticleComments).HasForeignKey(x => x.ArticleID);
        }
    }
}
