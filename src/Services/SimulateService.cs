using GenerateCoverageReportWithAction.CSharp.Demo.Services.Interfaces;

namespace GenerateCoverageReportWithAction.CSharp.Demo.Services
{
    public class SimulateService : IService
    {
        public string GetOutput(string input)
        {
            if (input == "A")
                return "B";
            else
                return "C";
        }
    }
}