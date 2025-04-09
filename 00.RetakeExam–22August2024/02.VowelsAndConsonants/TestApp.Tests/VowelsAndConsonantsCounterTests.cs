using System;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TestApp.Tests;

[TestFixture]
public class VowelsAndConsonantsCounterTests
{
    [Test]
    public void Test_AnalyzeSentence_EmptyString_ReturnsEmptyDictionary()
    {
        // Arrange
        string input = "";
        Dictionary<string, int> expected = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> actual = VowelsAndConsonantsCounter.AnalyzeSentence(input);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_AnalyzeSentence_OnlyVowelsRichWords_ReturnsDictionaryWithVowelsRichWordsOnly()
    {
        // Arrange
        string input = "Alo, alo";
        Dictionary<string, int> expected = new Dictionary<string, int>() 
        {
            ["vowel-rich"] = 2
        
        };

        // Act
        Dictionary<string, int> actual = VowelsAndConsonantsCounter.AnalyzeSentence(input);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_AnalyzeSentence_OnlyConsonantsRichWords_ReturnsDictionaryWithConsonantsRichWordsOnly()
    {
        // Arrange
        string input = "Hello World";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            ["consonant-rich"] = 2

        };

        // Act
        Dictionary<string, int> actual = VowelsAndConsonantsCounter.AnalyzeSentence(input);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_AnalyzeSentence_OnlyBalancedWords_ReturnsDictionaryWithBalancedWordsOnly()
    {
        // Arrange
        string input = "QA is cool";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            ["balanced"] = 3

        };

        // Act
        Dictionary<string, int> actual = VowelsAndConsonantsCounter.AnalyzeSentence(input);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_AnalyzeSentence_AllTypeOfWords_ReturnsDictionaryWithAllTypeOfEntries()
    {
        // Arrange
        string input = "The QA is awesome choice";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            ["vowel-rich"] = 1,
            ["consonant-rich"] = 1,
            ["balanced"] = 3

        };

        // Act
        Dictionary<string, int> actual = VowelsAndConsonantsCounter.AnalyzeSentence(input);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }
}

