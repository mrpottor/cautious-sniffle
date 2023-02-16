namespace UserAPI.Exceptions
{
    public class ProductNotFoundException:ApplicationException

    {
        public ProductNotFoundException() { }
        public ProductNotFoundException(string msg) : base(msg) { }
    }
}
