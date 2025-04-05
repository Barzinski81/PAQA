using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        int input = 0;
        Dictionary<int, int> expected = new Dictionary<int, int>(){};

        // Act 
        Dictionary<int, int> actual = NumberFrequency.CountDigits(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int input = 3;
        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            {3, 1}
        };

        // Act 
        Dictionary<int, int> actual = NumberFrequency.CountDigits(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int input = 35353532;
        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            {3, 4},
            {5, 3},
            {2, 1}
        };

        // Act 
        Dictionary<int, int> actual = NumberFrequency.CountDigits(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int input = -2323233;
        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            {2, 3},
            {3, 4},
        };

        // Act 
        Dictionary<int, int> actual = NumberFrequency.CountDigits(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }
}
