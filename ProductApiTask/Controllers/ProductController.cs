using Microsoft.AspNetCore.Mvc;

namespace ProductApiTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        public ProductController()
        {

        }

        [HttpGet(Name = "GetProduct")]
        public ServiceResult GetProduct(int id)
        {


            return new ServiceResult { };



            }

    }
}