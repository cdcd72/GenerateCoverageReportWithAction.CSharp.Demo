using System;
using System.IO;
using GenerateCoverageReportWithAction.CSharp.Demo;
using NUnit.Framework;

namespace GenerateCoverageReportWithAction.IntegrationTest;

public class ProgramTests
{
    [Test]
    public void GetOutputWithAInput()
    {
        // Arrange
        using var sw = new StringWriter();

        Console.SetOut(sw);

        // Act
        Program.Main(["A"]);

        // Assert
        Assert.That($"{sw}", Is.EqualTo("B"));
    }

    [Test]
    public void GetOutputWithBInput()
    {
        // Arrange
        using var sw = new StringWriter();

        Console.SetOut(sw);

        // Act
        Program.Main(["B"]);

        // Assert
        Assert.That($"{sw}", Is.EqualTo("C"));
    }
}
