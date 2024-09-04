using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;

namespace YourNamespace.Controllers
{
    public class CustomerOrderController : Controller
    {
        public IActionResult Index()
        {
            // Basit bir model örneği oluşturuyoruz
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Jessica",
                LastName = "Wexler",
                Email = "jessica.wexler123456@example.com"
            };

            var orders = new List<Order>
            {
              new Order { OrderId = 1, ProductName = "Pc", Price = 1000, Quantity = 1 },
              new Order { OrderId = 2, ProductName = "MobilePhone", Price = 750, Quantity = 2 },
              new Order { OrderId = 3, ProductName = "Speaker", Price = 300, Quantity = 2 }
            };


            // ViewModel oluşturup view'a gönderiyoruz
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);
        }
    }
}