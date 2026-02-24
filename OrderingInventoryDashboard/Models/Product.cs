namespace OrderingInventoryDashboard.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
        public int LowStockThreshold { get; set; }
    }
}
