using SharedObject.Common;

namespace EShopAPI.Model
{
    public class ProductImage
    {
        public int Id { get; set; }

        public int ProductID { get; set; }

        public string ImagePath { get; set; }

        public string Caption { get; set; }

        public Confirm IsDefault { get; set; }

        public DateTime DateCreated { get; set; }

        public int SortOrder { get; set; }

        public long FileSize { get; set; }

        public Product Product { get; set; }
    }
}
