using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    // TODO: finish test
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> input = new List<int>();
        
        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.Empty);

    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int>() { 1, 2, 3, 4, 5 };
        string expected = $"Odd numbers: 1, 3, 5"
                          + Environment.NewLine
                          + "Even numbers: 2, 4";

        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int>() { 2, 6, 4, 8 };
        string expected = "Even numbers: 2, 6, 4, 8";
                          

        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int>() { 7, 3, 9, 1 };
        string expected = "Odd numbers: 7, 3, 9, 1";


        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int>() { -1, -2, -3, -4, -5 };
        string expected = $"Odd numbers: -1, -3, -5"
                          + Environment.NewLine
                          + "Even numbers: -2, -4";

        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
