using Microsoft.AspNetCore.Mvc;
using route_benchmark.Models;

namespace route_benchmark.Controllers
{
    public class RouteTestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}