namespace EShopAPI.Model
{
    public class Location
    {
        public int LocationID { get; set; }
        public string? Name { get; set; } 
        public string? Type { get; set; } 
        public string? NameWithType { get; set; } 
        public int? ParentCode { get; set; }
        public int? Level { get; set; }
    }
}
