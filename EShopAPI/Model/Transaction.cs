using SharedObject.Common;

namespace EShopAPI.Model
{
    public class Transaction
    {
        public int ID { set; get; }
        public DateTime TransactionDate { set; get; }
        public string ExternalTransactionID { set; get; }
        public decimal Amount { set; get; }
        public decimal Fee { set; get; }
        public string Result { set; get; } 
        public string Message { set; get; } 
        public TransactionStatus Status { set; get; }
        public string Provider { set; get; }
        public Guid UserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
