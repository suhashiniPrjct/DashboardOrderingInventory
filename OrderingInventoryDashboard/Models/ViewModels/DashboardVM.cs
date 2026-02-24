namespace OrderingInventoryDashboard.Models.ViewModels
{
    public class DashboardVM
    {
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
        public int TotalOrders => Orders?.Count ?? 0;
        public int PendingOrders => Orders?.Count(p => p.Status == "Pending") ?? 0;
        public int LowStockItems => Products?.Count(p => p.Stock < p.LowStockThreshold) ?? 0;// ?? can be applied to nullable value so added ? to products .
    }
}
