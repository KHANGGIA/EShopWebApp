using SharedObject.ViewModel.Common;
namespace SharedObject.ViewModel.Product
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public string LanguageID { get; set; }

        public int? CategoryID { get; set; }
    }
}
