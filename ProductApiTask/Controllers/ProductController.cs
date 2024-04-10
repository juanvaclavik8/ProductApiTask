using Microsoft.AspNetCore.Mvc;
using ProductApiTask.ServiceLayer;

namespace ProductApiTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IService _service;

        public ProductController(IService service)
        {
            _service = service;
        }

        [HttpGet(Name = "GetProduct")]
        public IServiceResult GetProduct(int id)
        {
            try
            {
                return _service.GetProduct(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}