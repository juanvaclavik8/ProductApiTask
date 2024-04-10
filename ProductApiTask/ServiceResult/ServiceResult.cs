using ProductApiTask.Product;

namespace ProductApiTask.ServiceResult
{
    public class ServiceResult
    {
        public bool IsSuccess{ get; set; }

        public Product Product { get; set; }
    }
}
