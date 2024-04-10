namespace ProductApiTask.DataAccessLayer
{
    public interface IDataAccess
    {
        IProduct GetProduct(int id);
    }
}
