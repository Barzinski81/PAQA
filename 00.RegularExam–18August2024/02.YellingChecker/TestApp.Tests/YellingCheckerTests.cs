using System;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TestApp.Tests;

[TestFixture]
public class YellingCheckerTests
{
    [Test]
    public void Test_AnalyzeSentence_EmptyString_ReturnsEmptyDictionary()
    {
        // Arrange
        string input = "";
        Dictionary<string, int> expected = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> actual = YellingChecker.AnalyzeSentence(input);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_AnalyzeSentence_OnlyUpperCaseWords_ReturnsDictionaryWithYellingEntriesOnly()
    {
        // Arrange
        string input = "HELLO WORLD";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            ["yelling"] = 2
        };

        // Act
        Dictionary<string, int> actual = YellingChecker.AnalyzeSentence(input);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_AnalyzeSentence_OnlyLowerCaseWords_ReturnsDictionaryWithSpeakingLowerEntriesOnly()
    {
        // Arrange
        string input = "hello world";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            ["speaking lower"] = 2
        };

        // Act
        Dictionary<string, int> actual = YellingChecker.AnalyzeSentence(input);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_AnalyzeSentence_OnlyMixedCaseWords_ReturnsDictionaryWithASpeakingNormalEntriesOnly()
    {
        // Arrange
        string input = "Hello World";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            ["speaking normal"] = 2
        };

        // Act
        Dictionary<string, int> actual = YellingChecker.AnalyzeSentence(input);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_AnalyzeSentence_LowerUpperMixedCasesWords_ReturnsDictionaryWithAllTypeOfEntries()
    {
        // Arrange
        string input = "Unit TESTING is the 1st step!!!";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            ["yelling"] = 1,
            ["speaking lower"] = 4,
            ["speaking normal"] = 1
        };

        // Act
        Dictionary<string, int> actual = YellingChecker.AnalyzeSentence(input);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }
}

