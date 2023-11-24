using Microsoft.VisualStudio.TestTools.UnitTesting;
using Veckans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veckans.Tests;

[TestClass()]
public class CalculatorTests
{
    [TestMethod()]
    public void AddTest()
    {
        // Arrange
        var expected = 5;

        // Act
        var actual = Calculator.Add(3, 2);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void AddTestNegative()
    {
        // Arrange
        var expected = -5;

        // Act
        var actual = Calculator.Add(-3, -2);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}