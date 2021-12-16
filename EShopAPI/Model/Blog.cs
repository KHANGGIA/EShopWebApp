using SharedObject.Common;
using System.ComponentModel.DataAnnotations;

namespace EShopAPI.Model
{
    public class Blog
    {
        public int PostID { get; set; }
        public string? Title { get; set; } 
        public string? Content { get; set; } 
        public string? ThumbImage { get; set; } 
        public Confirm Published { get; set; }
        public string? Alias { get; set; } 
        public DateTime CreateDate { get; set; }
        public string? Author { get; set; }
        public string? Tag { get; set; }
        public int View { get; set; }
    }
}
