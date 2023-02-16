namespace UserAPI.Exceptions
{
    public class ProductAlreadlyExistException : ApplicationException
    {
        public ProductAlreadlyExistException() { }
        public ProductAlreadlyExistException(string msg) : base(msg) { }
    }
}
