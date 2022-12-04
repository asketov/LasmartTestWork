using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Common.Exceptions.General;
using Microsoft.AspNetCore.Http;

namespace LasmartTestWork.Middlewares.Exception
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (NotFoundException ex)
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsJsonAsync(ex.Message);
            }

        }
    }
}
