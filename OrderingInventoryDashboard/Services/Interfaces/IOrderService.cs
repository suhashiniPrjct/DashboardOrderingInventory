using OrderingInventoryDashboard.Models;

namespace OrderingInventoryDashboard.Services.Interfaces
{
    public interface IOrderService
    {   
        public IEnumerable<Order> GetAllOrders();
    }
}
