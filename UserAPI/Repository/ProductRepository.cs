
using Microsoft.EntityFrameworkCore;
using UserAPI.MOdel;



namespace UserAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _dbcontext;
        public ProductRepository(DataContext dbcontext)
        {
           _dbcontext = dbcontext;
        }

        
        public int Addproduct(User user)
        {
            _dbcontext.Users.Add(user);


            return _dbcontext.SaveChanges();
        }

        public int Deleteproduct(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            return _dbcontext.Users.Where(n => n.Id == id).FirstOrDefault();
        }

        public List<User> GetUsers()
        {
            return _dbcontext.Users.ToList();
        }

        public int Updateproduct(int id, User user)
        {
            var prod = _dbcontext.Users.Where(p => p.Id == id).FirstOrDefault();
            prod.Name = user.Name;
            prod.Brand = user.Brand;
            prod.Quantity = user.Quantity;
            prod.Price = user.Price;
            _dbcontext.Entry<User>(prod).State = EntityState.Modified;
            return _dbcontext.SaveChanges();
        }
    }
}
