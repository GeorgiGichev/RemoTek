using Microsoft.AspNetCore.Mvc;
using RemoTek.Services.Orders;
using System.Threading.Tasks;

namespace RemoTekTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderService orderService;

        public HomeController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public async Task<IActionResult> Index()
        {
            var orders = await this.orderService.GetLatestTenOrders();

            return this.View(orders);
        }

    }
}
