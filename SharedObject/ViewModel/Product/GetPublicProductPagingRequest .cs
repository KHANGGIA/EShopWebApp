using SharedObject.ViewModel.Common;

namespace SharedObject.ViewModel.Product
{
    public class GetPublicProductPagingRequest:PagingRequestBase
    {
        public int? CategoryID { get; set; }
    }
}
