using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[] { };

        // Act
        string actual = Miner.Mine(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    
    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "GolD 8", "SiLveR 30"};
        
        // Act
        string actual = Miner.Mine(input);

        // Assert
        Assert.That(actual, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Arrange
        string[] input = new string[] { "GolD 8", "SiLveR 30", "silver 100", "GOLD 50", "gold 2" };

        // Act
        string actual = Miner.Mine(input);

        // Assert
        Assert.That(actual, Is.EqualTo($"gold -> 60{Environment.NewLine}silver -> 130"));
    }
}
