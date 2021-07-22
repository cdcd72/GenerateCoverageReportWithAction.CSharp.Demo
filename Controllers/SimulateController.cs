using GenerateCoverageReportWithAction.CSharp.Demo.Services.Interfaces;

namespace GenerateCoverageReportWithAction.CSharp.Demo.Controllers
{
    public class SimulateController
    {
        readonly IService service;

        public SimulateController(IService service) => this.service = service;

        public string GetOutput(string input) => service.GetOutput(input);
    }
}
