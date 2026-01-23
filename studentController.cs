using Microsoft.AspNetCore.Mvc;

namespace RoutingDemoMVC.Controllers
{
    public class StudentController : Controller
    {
       
        [Route("input/{id}")]
        public IActionResult Input(int id, string name)
        {
            string message = $"Student ID : " + id + " Student Name : " + name;
            return Content(message);
        }
    }
}
