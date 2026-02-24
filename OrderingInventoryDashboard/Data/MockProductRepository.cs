using OrderingInventoryDashboard.Models;

namespace OrderingInventoryDashboard.Data
{
    public class MockProductRepository
    {
        public IEnumerable<Product> GetAllProducts()
        {
            return new List<Product>
            {
               new Product { Id = 1, Name = "Laptop", Category = "Electronics", Stock = 10, LowStockThreshold = 5 },
               new Product { Id = 5, Name = "Mobile", Category = "Electronics", Stock = 32, LowStockThreshold = 10 },
                new Product { Id = 2, Name = "Mouse", Category = "Electronics", Stock = 2, LowStockThreshold = 5 },
                new Product { Id = 3, Name = "Desk Chair", Category = "Furniture", Stock = 15, LowStockThreshold = 5 },
                new Product { Id = 4, Name = "Notebook", Category = "Stationery", Stock = 50, LowStockThreshold = 20 }

            };
            
        }
    }
}
