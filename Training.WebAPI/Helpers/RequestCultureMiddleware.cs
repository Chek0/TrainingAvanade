using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Training.WebAPI.Helpers
{
    public class RequestCultureMiddleware
    {
        private readonly RequestDelegate _next;
        public RequestCultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var cultureQuery = context.Request.Query["culture"];

            if (!string.IsNullOrEmpty(cultureQuery))
            {
                CultureInfo.CurrentCulture = new CultureInfo(cultureQuery);
                CultureInfo.CurrentUICulture = new CultureInfo(cultureQuery);
            }

            await _next(context);
        }
    }
}
