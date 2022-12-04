using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace LasmartTestWork.Middlewares.Exception
{
    public static class ExceptionExtension
    {
        public static IApplicationBuilder UseExceptionCatcher(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
