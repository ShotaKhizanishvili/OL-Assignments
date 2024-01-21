namespace Inventory_Management_System
{
    public class Sale
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime SaleDate { get; set; }

        public Sale(int productId, int quantity, DateTime saleDate)
        {
            ProductId = productId;
            Quantity = quantity;
            SaleDate = saleDate;
        }
        public Sale()
        {

        }
    }
}