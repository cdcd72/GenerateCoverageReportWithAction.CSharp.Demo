using GenerateCoverageReportWithAction.CSharp.Demo.Services;
using NUnit.Framework;

namespace GenerateCoverageReportWithAction.UnitTest;

public class SimulateServiceTests
{
    [Test]
    public void GetOutputWithAInput()
    {
        // Arrange
        var simulateService = new SimulateService();

        // Act
        var output = simulateService.GetOutput("A");

        // Assert
        Assert.AreEqual("B", output);
    }

    [Test]
    public void GetOutputWithBInput()
    {
        // Arrange
        var simulateService = new SimulateService();

        // Act
        var output = simulateService.GetOutput("B");

        // Assert
        Assert.AreEqual("C", output);
    }
}
