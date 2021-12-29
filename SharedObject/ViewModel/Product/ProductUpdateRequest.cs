using Microsoft.AspNetCore.Http;
namespace SharedObject.ViewModel.Product
{
    public class ProductUpdateRequest
    {
        public int ProductID { get; set; }
        public string? SKU { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }
        public int Stock { set; get; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public DateTime DateCreated { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
        public string LanguageID { set; get; }
        public bool? IsFeatured { get; set; }
        public IFormFile ThumbnailImage { get; set; }
    }
}
