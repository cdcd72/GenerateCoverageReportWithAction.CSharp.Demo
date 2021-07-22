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
            using var output = new StringWriter();
            Console.SetOut(output);

            // Act
            Program.Main(new string[] { "A" });

            // Assert
            Assert.AreEqual("B", $"{output}".Trim());
        }

        [Test]
        public void GetOutputWithCResult()
        {
            // Arrange
            using var output = new StringWriter();
            Console.SetOut(output);

            // Act
            Program.Main(new string[] { "B" });

            // Assert
            Assert.AreEqual("C", $"{output}".Trim());
        }
    }
}