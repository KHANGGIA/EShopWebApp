using SharedObject.Common;

namespace EShopAPI.Model
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public string PaymentType { get; set; } 
        public Confirm Allowed { get; set; }
    }
}
