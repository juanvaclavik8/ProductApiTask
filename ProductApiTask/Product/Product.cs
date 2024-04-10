namespace ProductApiTask
{
    public class Product : IProduct
    {
        public int ID{ get; set; }

        public string Name { get; set; }

        public int Quantity{ get; set; }
    }
}
