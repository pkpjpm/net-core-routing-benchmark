using System;
namespace route_benchmark.Models
{
    public class RouteTimingModel
    {
		public const string BeforeRoutingTimestampKey = "before-routing";
		public const string AfterRountingTimestampKey = "after-routing";

        public DateTime BeforeRoutingTimestamp
		{
			get;
			set;
		}

        public DateTime AfterRoutingTimestamp
		{
			get;
			set;
		}

        public TimeSpan ElapsedRoutingTime
		{
			get;
			set;
		}
    }
}
