using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureFunctionIsolatedVersionExceptionHandler
{
    public static class ExceptionHandlerMiddlewareExtension
    {
        public static IServiceCollection AddExceptionHandlerOptions(this IServiceCollection builder)
        {
            return builder.AddScoped<ExceptionHandlerMiddleware>();
        }
    }
}
