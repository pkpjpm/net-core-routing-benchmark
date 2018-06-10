# net-core-routing-benchmark

This is a very simple .NET Core MVC project that demonstrates routing performance

The startup method dynamically generates 1,000,000 route templates of the form "special/[route number]. 
They all route to the same controller. Since they are added in order, and ASP.NET Core MVC processes routes in the
order they were added, you can easily see how long it take to process a route template. For "special/5" only 5 
templates are searched (in addtion to the default); for 999999, all million templates are searched except the
last 1. This is because the search stops as soon as a template match is found.
