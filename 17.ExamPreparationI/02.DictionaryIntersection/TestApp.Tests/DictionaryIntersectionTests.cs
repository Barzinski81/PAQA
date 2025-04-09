using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        Dictionary<string, int> dict2 = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> actual = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        CollectionAssert.IsEmpty(actual);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        Dictionary<string, int> dict2 = new Dictionary<string, int>() 
        {
            ["one"] = 1,
            ["two"] = 2,
            ["three"] = 3,
        };

        // Act
        Dictionary<string, int> actual = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        CollectionAssert.IsEmpty(actual);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            ["six"] = 6,
            ["seven"] = 7,
            ["nine"] =9
        };

        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            ["one"] = 1,
            ["two"] = 2,
            ["three"] = 3,
        };

        // Act
        Dictionary<string, int> actual = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        CollectionAssert.IsEmpty(actual);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            ["six"] = 6,
            ["two"] = 2,
            ["nine"] = 9
        };

        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            ["one"] = 1,
            ["two"] = 2,
            ["six"] = 6,
        };

        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            ["six"] = 6,
            ["two"] = 2,
        };

        // Act
        Dictionary<string, int> actual = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            ["six"] = 66,
            ["two"] = 2,
            ["nine"] = 9
        };

        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            ["one"] = 1,
            ["two"] = 222,
            ["six"] = 6,
        };
                
        // Act
        Dictionary<string, int> actual = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        CollectionAssert.IsEmpty(actual);
    }
}
