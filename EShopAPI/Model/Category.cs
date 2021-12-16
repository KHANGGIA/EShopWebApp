using SharedObject.Common;

namespace EShopAPI.Model
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public int ParentID{get; set;}
        public int Level { get; set;}
        public int Ordering { get; set;}
        public Status Published { get; set; }
        public string? ThumbImage {get ;set;}
        public string? Title {get ;set;}
        public string? Alias {get ;set;}
        public string? MetaDesc {get ;set;}
        public string? MetaKey  {get ;set;}
        public string? ImageCover {get ;set;}

        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
