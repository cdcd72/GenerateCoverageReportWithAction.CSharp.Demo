using System;
using GenerateCoverageReportWithAction.CSharp.Demo.Controllers;
using GenerateCoverageReportWithAction.CSharp.Demo.Services;
using GenerateCoverageReportWithAction.CSharp.Demo.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GenerateCoverageReportWithAction.CSharp.Demo
{
    static class Program
    {
        static void Main()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IService, SimulateService>()
                .AddTransient<SimulateController>()
                .BuildServiceProvider();

            var simulateController = serviceProvider.GetRequiredService<SimulateController>();

            // input = A，output = B
            // input != A，output = C
            Console.WriteLine(simulateController.GetOutput("A"));
            Console.WriteLine(simulateController.GetOutput("B"));
        }
    }
}
