using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class MergeDictionariesTests
{
    [Test]
    public void Test_Merge_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>() { };
        Dictionary<string, int> dict2 = new Dictionary<string, int>() { };
        Dictionary<string, int> expected = new Dictionary<string, int>() { };

        // Act
        Dictionary<string, int> actual = MergeDictionaries.Merge(dict1, dict2);
        
        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Merge_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsNonEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>() { };
        Dictionary<string, int> dict2 = new Dictionary<string, int>() 
        {
            {"one", 1 },
            {"two", 2 },
            {"three", 3 }
        };
        Dictionary<string, int> expected = new Dictionary<string, int>() 
        {
            {"one", 1 },
            {"two", 2 },
            {"three", 3 }
        };

        // Act
        Dictionary<string, int> actual = MergeDictionaries.Merge(dict1, dict2);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Merge_TwoNonEmptyDictionaries_ReturnsMergedDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            {"ten", 10 },
            {"nine", 9 },
            {"eight", 8 }

        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            {"one", 1 },
            {"two", 2 },
            {"three", 3 }
        };
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            {"ten", 10 },
            {"nine", 9 },
            {"eight", 8 },
            {"one", 1 },
            {"two", 2 },
            {"three", 3 }
        };

        // Act
        Dictionary<string, int> actual = MergeDictionaries.Merge(dict1, dict2);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Merge_OverlappingKeys_ReturnsMergedDictionaryWithValuesFromDict2()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            {"one", 1 },
            {"two", 2 },
            {"eight", 8 }

        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            {"one", 111 },
            {"two", 222 },
            {"three", 3 }
        };
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            {"eight", 8 },
            {"one", 111 },
            {"two", 222 },
            {"three", 3 }
        };
    }
}
