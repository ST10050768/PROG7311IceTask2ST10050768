using Microsoft.AspNetCore.Mvc;
using PROG7311IceTask2ST10050768.Models;
using PROG7311IceTask2ST10050768.Repository;

namespace PROG7311IceTask2ST10050768.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 25000 },
            new Product { Id = 2, Name = "Phone", Price = 5000 }
        };

            var order = new Order { Products = products };
            var message = _orderService.ProcessOrder(order);

            ViewBag.Message = message;
            return View();
        }
    }
}
