using SharedObject.Common;

namespace EShopAPI.Model
{
    public class Order
    {
        public int OrderID { get; set; }
        public string? OrderNo { get; set; }
        public Guid UserId { set; get; }
        public int PaymentID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Confirm Deleted { get; set; }
        public Confirm Paid { get; set; }
        public DateTime PaymentDate { get; set; }
        public string? Note { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
        public Payment Payment { get; set; }
        public AppUser AppUser { get; set; }

    }
}
