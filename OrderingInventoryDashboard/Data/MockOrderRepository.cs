using OrderingInventoryDashboard.Models;

namespace OrderingInventoryDashboard.Data
{
    public class MockOrderRepository
    {
        public IEnumerable<Order> GetAllOrders()
        {
            return new List<Order>
            {
                new Order { Id = 101, CustomerName = "Alice", Priority = "High", Status = "Pending", Items = new List<Orderitem> {
                    new Orderitem { ProductId = 1, ProductName = "Laptop", Quantity = 1, Price = 1200 }
                }},
                new Order { Id = 102, CustomerName = "Bob", Priority = "Normal", Status = "Approved", Items = new List<Orderitem> {
                    new Orderitem { ProductId = 2, ProductName = "Mouse", Quantity = 3, Price = 25 },
                    new Orderitem { ProductId = 4, ProductName = "Notebook", Quantity = 5, Price = 2 }
                }},
                new Order { Id = 103, CustomerName = "Charlie", Priority = "High", Status = "Pending", Items = new List<Orderitem>
                {
                    new Orderitem { ProductId = 3, ProductName = "Desk Chair", Quantity = 2, Price = 150 },
                    new Orderitem { ProductId = 2, ProductName = "Mouse", Quantity = 2, Price = 150 },
                    new Orderitem { ProductId = 5, ProductName = "Mobile", Quantity = 1, Price = 1500 }
                }}
            };
        }

    }
}
