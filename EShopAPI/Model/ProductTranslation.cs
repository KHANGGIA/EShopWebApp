namespace EShopAPI.Model
{
    public class ProductTranslation
    {
        public int Id { set; get; }
        public int ProductID { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }

        public string SeoAlias { get; set; }
        public string LanguageID { set; get; }

        public Product Product { get; set; }

        public Language Language { get; set; }
    }
}
