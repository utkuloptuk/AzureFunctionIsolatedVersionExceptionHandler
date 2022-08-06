
namespace AzureFunctionIsolatedVersionExceptionHandler
{
    using Microsoft.AspNetCore.Http;
    using Newtonsoft.Json;
    using System;
    using System.Threading.Tasks;
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            string message = default;
            string exceptionType = default;
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                message = ex.Message;
                exceptionType=ex.GetType().Name;
            }
            if(!context.Response.HasStarted)
            {
                context.Response.ContentType = "application/json";
                var response=new ExceptionResponse(message, exceptionType);
                var exception = JsonConvert.SerializeObject(response);
                await context.Response.WriteAsync(exception);
            }
        }
    }
}
