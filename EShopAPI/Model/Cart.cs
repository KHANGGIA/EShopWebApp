namespace EShopAPI.Model
{
    public class Cart
    {
        public int CartID { set; get; }
        public int ProductID { set; get; }
        public Guid UserId { get; set; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }
        public DateTime CreatedDate { set; get; }

        public Product Product { get; set; }

    }
}
