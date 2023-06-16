using WorkerService.App.Interface;
using WorkerService.App.Service;

namespace WorkerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddHostedService<Worker>()
                    .AddSingleton<IEmail, EmailService>()
                    .AddSingleton<IHttpService, HttpService>();
                })
                .Build();

            host.Run();
        }
    }
}