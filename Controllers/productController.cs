using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class productController : Controller
    {
        public IActionResult Index()
        {
            List<product> product = new List<product>()
            {
            new product { Id = 1, Name = "Laptop", Price = 55000 , Quantity =5},
            new product { Id = 1, Name = "Mobile", Price = 25000 , Quantity =5 },
            new product { Id = 1, Name = "Headphones", Price = 30000 ,Quantity =5} };
           

            return View(product);

        }
    }
}