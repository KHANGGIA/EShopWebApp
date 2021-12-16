using SharedObject.Common;

namespace EShopAPI.Model
{
    public class Language
    {
        public string LanguageID { get; set; } 
        public string Name { get; set; } 
        public Confirm IsDefault { get; set; }
        public List<ProductTranslation> ProductTranslations { get; set; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
