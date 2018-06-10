using Microsoft.AspNetCore.Mvc;
using route_benchmark.Models;

namespace route_benchmark.Controllers
{
    class RouteTestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}