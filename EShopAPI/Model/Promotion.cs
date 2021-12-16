using SharedObject.Common;

namespace EShopAPI.Model
{
    public class Promotion
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public DateTime FromDate { set; get; }
        public DateTime ToDate { set; get; }
        public Confirm ApplyForAll { set; get; }
        public int? DiscountPercent { set; get; }
        public decimal? DiscountAmount { set; get; }
        public string ProductIds { set; get; }
        public string ProductCategoryIds { set; get; }
        public Confirm DiscountStatus { get; set; }
       
    }
}
