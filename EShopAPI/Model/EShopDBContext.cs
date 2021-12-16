using EShopAPI.Configuration;
using Microsoft.EntityFrameworkCore;

namespace EShopAPI.Model
{
    public class EShopDBContext : DbContext
    {
        public EShopDBContext(DbContextOptions<EShopDBContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());
            modelBuilder.ApplyConfiguration(new ShipperConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
            modelBuilder.ApplyConfiguration(new ArticleConfiguration());
            modelBuilder.ApplyConfiguration(new ArticleCommentConfiguration());
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
        }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Product> Products { get; set; } 
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Order> Orders { get; set; } 
        public DbSet<OrderDetail> OrderDetails { get; set; } 
        public DbSet<Location> Locations { get; set; } 
        public DbSet<Supplier> Suppliers { get; set; } 
        public DbSet<Shipper> Shippers { get; set; } 
        public DbSet<Payment> Payments { get; set; } 
        public DbSet<Article> Articles { get; set; } 
        public DbSet<ArticleComment> ArticleComments { get; set; } 
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Language> Languages { get; set; } 
        public DbSet<Transaction> Transactions { get; set; } 
        public DbSet<AppConfig> AppConfigs { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<ProductInCategory> ProductInCategories { get; set; }
        public DbSet<ProductTranslation> ProductTranslations { get; set; }
        public DbSet<CategoryTranslation> CategoryTranslations { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}
