using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[] { };

        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }


    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[] { "test", "text", "test", "text" };

        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] input = new string[] { "test", "text", "test", "text", "text" };
        string expected = "text";

        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] input = new string[] { "test", "text", "test", "text", "text", "test", "name" };
        string expected = "test text name";

        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "teSt", "tExT", "tEst", "Text", "teXT", "TEST", "nAmE" };
        string expected = "test text name";

        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
