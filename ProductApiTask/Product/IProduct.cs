namespace ProductApiTask
{
    public interface IProduct
    {
        int ID { get; set; }

        string Name { get; set; }

        int Quantity { get; set; }
    }
}
