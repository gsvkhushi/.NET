using System.Diagnostics;
using dependencyproject.Models;
using dependencyproject.services;
using Microsoft.AspNetCore.Mvc;

namespace dependencyproject.Controllers
{
    public class HomeController : Controller
    {
        private readonly Imyservice _service;

        public HomeController(Imyservice service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            string message = _service.GetMessage();
            return Content(message);
        }
        
    }
}
