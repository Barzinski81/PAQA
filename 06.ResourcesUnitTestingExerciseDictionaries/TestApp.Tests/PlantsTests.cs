using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[] { };
        string expected = "";
        // Act
        string actual = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] input = new string[] { "Rose" };
        string expected = $"Plants with 4 letters:"
                          + Environment.NewLine
                          + "Rose";
        // Act
        string actual = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] input = new string[] { "Rose", "Beech", "Aloe", "Lavender" };
        string expected = $"Plants with 4 letters:"
                          + Environment.NewLine
                          + "Rose"
                          + Environment.NewLine
                          + "Aloe"
                          + Environment.NewLine
                          + "Plants with 5 letters:"
                          + Environment.NewLine
                          + "Beech"
                          + Environment.NewLine
                          + "Plants with 8 letters:"
                          + Environment.NewLine
                          + "Lavender";
        // Act
        string actual = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "rose", "Beech", "aloe", "Lavender" };
        string expected = $"Plants with 4 letters:"
                          + Environment.NewLine
                          + "rose"
                          + Environment.NewLine
                          + "aloe"
                          + Environment.NewLine
                          + "Plants with 5 letters:"
                          + Environment.NewLine
                          + "Beech"
                          + Environment.NewLine
                          + "Plants with 8 letters:"
                          + Environment.NewLine
                          + "Lavender";
        // Act
        string actual = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
