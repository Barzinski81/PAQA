using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>()
        {
            {"apple", 5 },
            {"orange", 10 },
            {"pear", 8 },
            {"banana", 15 }
        };

        string fruit = "pear";
        int expected = 8;

        // Act
        int actual = Fruits.GetFruitQuantity(input, fruit);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>()
        {
            {"apple", 5 },
            {"orange", 10 },
            {"pear", 8 },
            {"banana", 15 }
        };

        string fruit = "mango";
        int expected = 0;

        // Act
        int actual = Fruits.GetFruitQuantity(input, fruit);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        Dictionary<string, int> input = new Dictionary<string, int>(){};

        string fruit = "mango";
        int expected = 0;

        // Act
        int actual = Fruits.GetFruitQuantity(input, fruit);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        Dictionary<string, int> input = null;

        string fruit = "mango";
        int expected = 0;

        // Act
        int actual = Fruits.GetFruitQuantity(input, fruit);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>()
        {
            {"apple", 5 },
            {"orange", 10 },
            {"pear", 8 },
            {"banana", 15 }
        };

        string fruit = null;
        int expected = 0;

        // Act
        int actual = Fruits.GetFruitQuantity(input, fruit);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
