using UserAPI.Exceptions;
using UserAPI.MOdel;
using UserAPI.Repository;
namespace UserAPI.Service
{
    public class ProductServices : IProductService
    {
        private readonly IProductRepository repo;
        public ProductServices(IProductRepository _repo)
        {
            repo = _repo;
        }
        public int AddProduct(User user)
        {
            if (repo.GetUser(user.Id) != null)
            {
                throw new ProductAlreadlyExistException($"Customer with customer id {user.Id} already exists");
            }
            return repo.Addproduct(user);
        }
        public int DeleteProduct(int id)
        {
            if (repo.GetUser(id) == null)
            {
                throw new ProductNotFoundException($"Customer with customer id {id} does not exists");
            }
            return repo.Deleteproduct(id);
        }
        public User GetUsers(int id)
        {
            User c = repo.GetUser(id);
            if (c == null)
            {
                throw new ProductNotFoundException($"Customer with customer id {id} does not exists");
            }
            return c;
        }
        public User GetProduct(int id)
        {
            return repo.GetUser(id);
        }
        public List<User> GetProducts()
        {
            return repo.GetUsers();
        }
        public int UpdateProduct(int id, User user)
        {
            if (repo.GetUser(id) == null)
            {
                throw new ProductNotFoundException($"Customer with customer id {id} does not exists");
            }
            return repo.Updateproduct(id, user);
        }
    }
}
