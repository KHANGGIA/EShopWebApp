using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SharedObject.ViewModel.Product
{
    public class ProductCreateRequest
    {
        public string? SKU { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public DateTime DateCreated { set; get; }
        public int ViewCount { set; get; }
        public string SeoAlias { set; get; }
        public string LanguageID { set; get; }
        public bool? IsFeatured { get; set; }
        public IFormFile ThumbnailImage { get; set; }
    }
}
