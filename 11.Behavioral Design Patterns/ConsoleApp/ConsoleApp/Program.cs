using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System;
using System.Reflection;

namespace ConsoleApp
{
    public class Program
    {
        private readonly ILogger<Program> _logger;
        private readonly IMediator _mediator;
        static void Main(string[] args)
        {
            CreateHostBuilder(args)
                .Build()
                .Services.GetRequiredService<Program>()
                .Run();
        }

        public Program(ILogger<Program> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public void Run()
        {
            _mediator.Send(new SimpleRequest("Open the door!"));
            _mediator.Send(new PoliteRequest("Open the door!"));
            _logger.LogInformation("Program completed!!");
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddTransient<Program>();
                    services.AddMediatR(Assembly.GetExecutingAssembly());
                });
        }
    }
}
