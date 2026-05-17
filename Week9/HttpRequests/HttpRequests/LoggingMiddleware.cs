using Microsoft.AspNetCore.Mvc.Filters;

namespace HttpRequests;

public class LoggingMiddleware : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine("Reached to Action");
    }
}
