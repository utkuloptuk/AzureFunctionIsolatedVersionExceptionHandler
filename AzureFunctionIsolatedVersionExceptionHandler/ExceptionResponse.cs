
namespace AzureFunctionIsolatedVersionExceptionHandler
{
    using Newtonsoft.Json;

    public class ExceptionResponse
    {
        public int StatusCode { get; set; }
        public string ExceptionType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }
        public ExceptionResponse(string message, string exceptionType, int statusCode = 500)
        {
            Message = message;
            ExceptionType = exceptionType;
            StatusCode = statusCode;
        }
    }
}
