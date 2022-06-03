
namespace SampleTestWebAPI.Modals
{
    public class Product
    {
        public string ProductName { get; }
        public decimal Price { get; }
        public string Description { get; }

        public Product(string pname,int price, string desc)
        {
            ProductName = pname;
            Price = price;
            Description = desc;
        }
    }
}
