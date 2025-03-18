using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    // TODO: finish test
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] input = new int[] { };
        string expected = string.Empty;

        // Act
        string actual = CountRealNumbers.Count(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 5 };
        string expected = "5 -> 1";

        // Act
        string actual = CountRealNumbers.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 5, 3, 3, 5, 8 };
        string expected = $"3 -> 2"
             + Environment.NewLine
             + "5 -> 2"
             + Environment.NewLine
             + "8 -> 1";

        // Act
        string actual = CountRealNumbers.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { -5, -3, -3, -5, -2 };
        string expected = $"-5 -> 2"
             + Environment.NewLine
             + "-3 -> 2"
             + Environment.NewLine
             + "-2 -> 1";

        // Act
        string actual = CountRealNumbers.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 0, 0, 0, 0, 0 };
        string expected = "0 -> 5";

        // Act
        string actual = CountRealNumbers.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
