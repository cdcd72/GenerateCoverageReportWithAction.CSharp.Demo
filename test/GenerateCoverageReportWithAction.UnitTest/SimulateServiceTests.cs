using GenerateCoverageReportWithAction.CSharp.Demo.Services;
using NUnit.Framework;

namespace GenerateCoverageReportWithAction.UnitTest
{
    public class SimulateServiceTests
    {
        [Test]
        public void GetOutputWithBResult()
        {
            // Arrange
            var simulateController = new SimulateService();

            // Act
            var output = simulateController.GetOutput("A");

            // Assert
            Assert.AreEqual("B", output);
        }

        [Test]
        public void GetOutputWithCResult()
        {
            // Arrange
            var simulateController = new SimulateService();

            // Act
            var output = simulateController.GetOutput("B");

            // Assert
            Assert.AreEqual("C", output);
        }
    }
}
