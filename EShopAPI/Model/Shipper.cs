﻿namespace EShopAPI.Model
{
    public class Shipper
    {
        public int ShipperID { get; set; }
        public string ShipperName { get; set; } 
        public string CompanyName  {get;set;} 
        public string Phone { get; set; } 
        public DateTime ShipDate { get; set; }
    }
}