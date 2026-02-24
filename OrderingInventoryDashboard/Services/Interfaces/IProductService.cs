using OrderingInventoryDashboard.Models;

namespace OrderingInventoryDashboard.Services.Interfaces
{
    public interface IProductService
    {   
        public IEnumerable<Product> GetAllProducts();
    }
}
