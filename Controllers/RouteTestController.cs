using System;
using Microsoft.AspNetCore.Mvc;
using route_benchmark.Models;
using route_benchmark.Pipeline;

namespace route_benchmark.Controllers
{
	[TimingResourceFilter]
	public class RouteTestController : Controller
    {
        public IActionResult Index()
        {
			var model = new RouteTimingModel
			{
                BeforeRoutingTimestamp = (DateTime)HttpContext.Items[RouteTimingModel.BeforeRoutingTimestampKey],
                AfterRoutingTimestamp = (DateTime)HttpContext.Items[RouteTimingModel.AfterRountingTimestampKey]				                                              
			};

			model.ElapsedRoutingTime = model.AfterRoutingTimestamp - model.BeforeRoutingTimestamp;
            
            return View(model);
        }

    }
}