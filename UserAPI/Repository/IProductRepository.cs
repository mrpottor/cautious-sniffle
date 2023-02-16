using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.MOdel;

namespace UserAPI.Repository
{
    public interface IProductRepository
    {
        List<User> GetUsers();
        User GetUser(int id);
        int Addproduct(User user);
        int Updateproduct(int id, User user);
        int Deleteproduct(int id);
    }
}
