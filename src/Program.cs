using System;
using GenerateCoverageReportWithAction.CSharp.Demo.Controllers;
using GenerateCoverageReportWithAction.CSharp.Demo.Services;
using GenerateCoverageReportWithAction.CSharp.Demo.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GenerateCoverageReportWithAction.CSharp.Demo
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IService, SimulateService>()
                .AddTransient<SimulateController>()
                .BuildServiceProvider();

            var simulateController = serviceProvider.GetRequiredService<SimulateController>();

            if (args.Length > 0)
            {
                var input = args[0];

                // input = A，output = B
                // input != A，output = C
                Console.WriteLine(simulateController.GetOutput(input));
            }
        }
    }
}
