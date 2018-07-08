using System;
using Microsoft.AspNetCore.Mvc.Filters;
using route_benchmark.Models;

namespace route_benchmark.Pipeline
{
	/// <summary>
    /// Resource filters come early in the filter chain, right after auth filters,
	/// so it's a good place to capture a timestamp that is close to the completion
	/// of route resolution
    /// </summary>
	public class TimingResourceFilterAttribute : Attribute, IResourceFilter
    {
		public void OnResourceExecuted(ResourceExecutedContext context)
		{
		}

		public void OnResourceExecuting(ResourceExecutingContext context)
		{
			context.HttpContext.Items[RouteTimingModel.AfterRountingTimestampKey] = DateTime.UtcNow;
		}
	}
}
