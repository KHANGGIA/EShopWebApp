using SharedObject.Common;

namespace EShopAPI.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? SKU { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int SupplierID { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public Confirm ProductStatus { get; set; }
        public DateTime DateCreated { set; get; }
        public int ViewCount { set; get; }
        public string SeoAlias { set; get; }

        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }
        public List<ProductTranslation> ProductTranslations { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
