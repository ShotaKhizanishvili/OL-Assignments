namespace Inventory_Management_System
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }

        public Product(string name, decimal price, int stock, int categoryId)
        {
            Name = name;
            Price = price;
            Stock = stock;
            CategoryId = categoryId;
        }
        public Product()
        {

        }
    }
}