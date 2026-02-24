namespace OrderingInventoryDashboard.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Priority { get; set; } // Normal, High
        public string Status { get; set; }   // Pending, Approved, Completed
        public DateTime OrderDate { get; set; }
        public List<Orderitem> Items { get; set; } = new List<Orderitem>();
        public decimal TotalAmount => Items != null ? Items.Sum(i => i.Total) : 0;   
    }
}
