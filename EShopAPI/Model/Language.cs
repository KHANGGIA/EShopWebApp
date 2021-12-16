using SharedObject.Common;

namespace EShopAPI.Model
{
    public class Language
    {
        public string LanguageID { get; set; } 
        public string Name { get; set; } 
        public Confirm IsDefault { get; set; }
    }
}
