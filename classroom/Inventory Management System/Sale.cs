namespace Inventory_Management_System
{
    public class Sale
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
