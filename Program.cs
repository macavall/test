using Microsoft.Extensions.Hosting;

namespace test
{
    public class Program
    {
        public static void Main()
        {
            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .Build();

                // test 

            host.Run();
        }
    }
}
