namespace SharedObject.ViewModel.Common
{
    public class PagingResult<T> :PaginationResultBase
    {
        public List<T> Items { get; set;}
    }
}
