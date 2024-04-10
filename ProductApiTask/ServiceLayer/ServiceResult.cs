namespace ProductApiTask.ServiceLayer
{
    public class ServiceResult : IServiceResult
    {
        public bool IsSuccess { get; set; }

        public IProduct? Product { get; set; }

        public ServiceResult(bool isSuccess, IProduct? product)
        {
            IsSuccess = isSuccess;
            Product = product;
        }
    }
}
