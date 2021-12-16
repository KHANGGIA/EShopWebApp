using SharedObject.Common;

namespace EShopAPI.Model
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; } 
        public string ContactTitle { get; set; } 
        public string Address { get; set; }
        public string PhoneNo { get; set; } 
        public string Email { get; set; } 
        public string City { get; set; } 
        public string Country { get; set; } 
        public string PaymentMethod { get; set; } 
        public string DiscountType { get; set; } 
        public Status DiscountStatus { get; set; }
        public string? Note { get; set; } 
        public string Logo { get; set; } 
        public string URL { get; set; }
    }
}
