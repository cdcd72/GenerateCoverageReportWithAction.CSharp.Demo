using System;
using System.IO;
using GenerateCoverageReportWithAction.CSharp.Demo;
using NUnit.Framework;

namespace GenerateCoverageReportWithAction.IntegrationTest
{
    public class ProgramTests
    {
        [Test]
        public void GetOutputWithBResult()
        {
            // Arrange
            using var sw = new StringWriter();

            Console.SetOut(sw);

            // Act
            Program.Main(new string[] { "A" });

            // Assert
            Assert.AreEqual("B", $"{sw}".Trim());
        }

        [Test]
        public void GetOutputWithCResult()
        {
            // Arrange
            using var sw = new StringWriter();

            Console.SetOut(sw);

            // Act
            Program.Main(new string[] { "B" });

            // Assert
            Assert.AreEqual("C", $"{sw}".Trim());
        }
    }
}
