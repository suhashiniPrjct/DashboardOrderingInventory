using OrderingInventoryDashboard.Data;
using OrderingInventoryDashboard.Models;
using OrderingInventoryDashboard.Services.Interfaces;

namespace OrderingInventoryDashboard.Services
{
    public class OrderService: IOrderService
    {
        public readonly MockOrderRepository _mockOrderRepository;

        public  OrderService(MockOrderRepository mockOrderRepository)
        {
            _mockOrderRepository = mockOrderRepository;
        }
        public IEnumerable<Order> GetAllOrders()
        {
          return _mockOrderRepository.GetAllOrders();
        }
    }
}
