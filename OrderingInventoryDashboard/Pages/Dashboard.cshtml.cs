using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrderingInventoryDashboard.Models.ViewModels;
using OrderingInventoryDashboard.Services.Interfaces;

namespace OrderingInventoryDashboard.Pages
{
    public class DashboardModel : PageModel
    {
        private readonly IProductService _productservice;
        private readonly IOrderService   _orderService;
        public DashboardVM DashboardData { get; set; } = new DashboardVM();

        public DashboardModel (IProductService productservice, IOrderService orderService)
        {
            _productservice = productservice;
            _orderService = orderService;
        }
        public void OnGet()           
        {
            DashboardData.Products = _productservice.GetAllProducts().ToList();
            DashboardData.Orders = _orderService.GetAllOrders().ToList();
            
        }
    }
}
