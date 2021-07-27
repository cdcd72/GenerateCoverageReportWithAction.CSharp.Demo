using GenerateCoverageReportWithAction.CSharp.Demo.Controllers;
using GenerateCoverageReportWithAction.CSharp.Demo.Services.Interfaces;
using Moq;
using NUnit.Framework;

namespace GenerateCoverageReportWithAction.UnitTest
{
    public class SimulateControllerTests
    {
        [Test]
        public void GetOutputWithAInput()
        {
            // Arrange
            var mockService = new Mock<IService>();

            // 模擬 Service 給 A 回 B
            _ = mockService.Setup(m => m.GetOutput(It.Is<string>(i => i == "A")))
                           .Returns("B");

            var simulateController = new SimulateController(mockService.Object);

            // Act
            var output = simulateController.GetOutput("A");

            // Assert
            Assert.AreEqual("B", output);
        }

        [Test]
        public void GetOutputWithBInput()
        {
            // Arrange
            var mockService = new Mock<IService>();

            // 模擬 Service 給 != A 回 C
            _ = mockService.Setup(m => m.GetOutput(It.Is<string>(i => i != "A")))
                           .Returns("C");

            var simulateController = new SimulateController(mockService.Object);

            // Act
            var output = simulateController.GetOutput("B");

            // Assert
            Assert.AreEqual("C", output);
        }
    }
}
