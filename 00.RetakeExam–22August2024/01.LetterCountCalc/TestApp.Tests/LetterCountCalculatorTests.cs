using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

[TestFixture]
public class LetterCountCalculatorTests
{
    [Test]
    public void Test_Calculate_EmptyString_ReturnsZero()
    {
        // Arrange
        string input = "";
        int expected = 0;

        // Act
        int actual = LetterCountCalculator.Calculate(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Calculate_NoUpperCase_ReturnsZero()
    {
        // Arrange
        string input = "test";
        int expected = 0;

        // Act
        int actual = LetterCountCalculator.Calculate(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Calculate_NoLowerCase_ReturnsZero()
    {
        // Arrange
        string input = "TEXT";
        int expected = 0;

        // Act
        int actual = LetterCountCalculator.Calculate(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Calculate_UpperAndLowerCase_ReturnsCorrectInteger()
    {
        // Arrange
        string input = "SoftUni";
        int expected = 10;

        // Act
        int actual = LetterCountCalculator.Calculate(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

