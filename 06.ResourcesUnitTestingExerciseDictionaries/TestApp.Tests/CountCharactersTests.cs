using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() { "", "", "", "" };

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "x" };
        string expected = "x -> 1";

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "abc", "bbc", "bad", "dad", "bed" };
        string expected = $"a -> 3"
            + Environment.NewLine
            + "b -> 5"
            + Environment.NewLine
            + "c -> 2"
            + Environment.NewLine
            + "d -> 4"
            + Environment.NewLine
            + "e -> 1";

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "ab#", "bb@", "ba#" };
        string expected = $"a -> 2"
            + Environment.NewLine
            + "b -> 4"
            + Environment.NewLine
            + "# -> 2"
            + Environment.NewLine
            + "@ -> 1";

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
