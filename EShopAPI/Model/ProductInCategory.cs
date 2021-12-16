namespace EShopAPI.Model
{
    public class ProductInCategory
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
