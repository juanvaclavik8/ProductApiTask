namespace ProductApiTask.ServiceLayer
{
    public interface IServiceResult
    {
        bool IsSuccess { get; set; }

        IProduct? Product { get; set; }
    }
}
