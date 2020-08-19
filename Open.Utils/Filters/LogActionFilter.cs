using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Open.Utils
{
    public class LogActionFilter : IAsyncActionFilter
    {
        private readonly ILogHandler _logHandler;

        public LogActionFilter(ILogHandler opratoinLogHandler)
        {
            _logHandler = opratoinLogHandler;
        }

        public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            return _logHandler.LogAsync(context, next);
        }
    }
}
