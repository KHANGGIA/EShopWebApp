using SharedObject.Common;
namespace EShopAPI.Model
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Status Allowed { get; set; }

        public List<ArticleComment> ArticleComments { get; set; }
    }
}
