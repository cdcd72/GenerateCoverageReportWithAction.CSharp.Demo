using GenerateCoverageReportWithAction.CSharp.Demo.Services.Interfaces;

namespace GenerateCoverageReportWithAction.CSharp.Demo.Controllers;

public class SimulateController(IService service)
{
    public string GetOutput(string input) => service.GetOutput(input);
}
