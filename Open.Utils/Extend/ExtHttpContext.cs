using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Open.Utils
{
    public static class ExtHttpContext
    {
        //public static void AddHttpContextAccessor(this IServiceCollection services)
        //{
        //    services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        //}

        //public static IApplicationBuilder UseStaticHttpContext(this IApplicationBuilder app)
        //{
        //    var httpContextAccessor = app.ApplicationServices.GetRequiredService<IHttpContextAccessor>();
        //    HttpContext.Configure(httpContextAccessor);
        //    return app;
        //}
    }
}
