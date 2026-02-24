using OrderingInventoryDashboard.Data;
using OrderingInventoryDashboard.Models;
using OrderingInventoryDashboard.Services.Interfaces;

namespace OrderingInventoryDashboard.Services
{
    public class ProductService:IProductService
    {
        private readonly MockProductRepository _mockProductRepository;
         public ProductService(MockProductRepository mockProductRepository)
        {
            _mockProductRepository = mockProductRepository;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            var products = _mockProductRepository.GetAllProducts();
            return products;
        }
    }
}
