using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrderingInventoryDashboard.Services.Interfaces;

namespace OrderingInventoryDashboard.Pages
{
    public class DashboardModel : PageModel
    {
        private readonly IProductService _productservice;
        private readonly IOrderService   _orderService;

        public DashboardModel (IProductService productservice, IOrderService orderService)
        {
            _productservice = productservice;
            _orderService = orderService;
        }
        public void OnGet()
        {
            var products= _productservice.GetAllProducts();
             var orders= _orderService.GetAllOrders().ToList();
        }
    }
}
