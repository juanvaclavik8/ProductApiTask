namespace ProductApiTask.DataAccessLayer
{
    public class DataAccess : IDataAccess
    {
        public IProduct GetProduct(int id)
        {
            // Example data
            var products = new List<Product>();
            products.Add(new Product { ID = 1, Name = "Knee pad", Quantity = 10 });
            products.Add(new Product { ID = 2, Name = "Helmet", Quantity = 20 });
            products.Add(new Product { ID = 3, Name = "Elbow guards", Quantity = 30 });
            products.Add(new Product { ID = 4, Name = "Hand sleeve", Quantity = 40 });
            products.Add(new Product { ID = 5, Name = "Sports bag", Quantity = 50 });

            // Try to fetch product
            try
            {
                return products.First(p => p.ID == id);
            }
            catch (Exception)
            {
                // Return not found if id not valid
                var ex = new Exception($"Product ID = {id} not found.");
                throw ex;
            }
        }
    }
}
