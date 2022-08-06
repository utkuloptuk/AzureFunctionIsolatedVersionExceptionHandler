
namespace AzureFunctionIsolatedVersionExceptionHandler
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Hosting;

    public class Program
    {
        public static void Main()
        {
            var host = new HostBuilder()
                .ConfigureAppConfiguration((context, configuration) =>
                configuration.AddJsonFile("local.settings.json", optional: true, reloadOnChange: false)
                )
                .ConfigureFunctionsWorkerDefaults()
                .ConfigureServices((services) =>
                {
                    services.AddExceptionHandlerOptions();
                }
                )
                .Build();

            host.Run();
        }
    }
}