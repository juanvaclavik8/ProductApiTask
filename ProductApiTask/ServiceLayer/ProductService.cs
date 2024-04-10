using ProductApiTask.DataAccessLayer;
using ProductApiTask.Logging;

namespace ProductApiTask.ServiceLayer
{
    public class ProductService : IService
    {
        private readonly IDataAccess _dataAccess;
        private readonly ILogging _logging;

        public ProductService(IDataAccess dataAccess, ILogging logging)
        {
            _dataAccess = dataAccess;
            _logging = logging;
        }

        public IServiceResult GetProduct(int id)
        {
            try
            {
                var product = _dataAccess.GetProduct(id);

                _logging.Log($"Product ID = {id} found.", "Success");

                return new ServiceResult(true, product);
            }
            catch (Exception)
            {
                _logging.Log($"Product ID = {id} not found.", "Failure");

                return new ServiceResult(false, null);
            }
        }
    }
}
