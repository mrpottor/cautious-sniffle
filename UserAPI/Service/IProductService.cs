using Microsoft.EntityFrameworkCore;
using UserAPI.MOdel;

namespace UserAPI.Service
{
    public interface IProductService
    {
        List<User> GetProducts();
        User GetProduct(int id);
        int AddProduct(User user);
        int UpdateProduct(int id, User user);
        int DeleteProduct(int id);
    }
}
