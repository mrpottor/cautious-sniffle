using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserAPI.Service;
using UserAPI.MOdel;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IProductService service;
        public ProductController(IProductService _service)
        {
            service = _service;
        }
        [HttpGet]
        public List<User> Get()
        {
            return service.GetProducts();
        }

        [HttpPost]
        public ActionResult Post(User user)
        {
            var result = service.AddProduct(user);
            if (result == 1)
            {
                return StatusCode(201, $"{result} Record Added");
            }
            return StatusCode(500);
        }
    }
}
