using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChannelEngine.Web.Middlewares
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _requestDelegate;

        public ErrorHandlingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;

        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _requestDelegate(httpContext);
            }
            catch (Exception ex)
            {

            }
        }
    }

    public static class MiddlewareRegistrationExtension
    {
        public static void UseAppException(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<ErrorHandlingMiddleware>();
        }
    }
}
