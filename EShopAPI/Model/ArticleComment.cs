namespace EShopAPI.Model
{
    public class ArticleComment
    {
        public int ID { get; set; }
        public string? Comment { get; set; }
        public DateTime CommentOn { get; set; }
        public int ArticleID { get; set; }
        public int Rating { get; set; }
        public Article Article { get; set; }

    }
}
