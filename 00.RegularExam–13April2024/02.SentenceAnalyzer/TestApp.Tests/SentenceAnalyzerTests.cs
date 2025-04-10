using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SentenceAnalyzerTests
{
    [Test]
    public void Test_Analyze_EmptyString_ReturnsEmptyDictionary()
    {
        // Arrange
        string input = "";
        Dictionary<string, int> expected = new Dictionary<string, int> ();

        // Act
        Dictionary<string, int> actual = SentenceAnalyzer.Analyze(input);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_Analyze_SingleLetter_ReturnsDictionaryWithSingleLetterEntry()
    {
        // Arrange
        string input = "A";
        Dictionary<string, int> expected = new Dictionary<string, int>() 
        {
            ["letters"] = 1        
        };

        // Act
        Dictionary<string, int> actual = SentenceAnalyzer.Analyze(input);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_Analyze_SingleDigit_ReturnsDictionaryWithSingleDigitEntry()
    {
        // Arrange
        string input = "5";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            ["digits"] = 1
        };

        // Act
        Dictionary<string, int> actual = SentenceAnalyzer.Analyze(input);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_Analyze_WholeSentence_ReturnsDictionaryWithAllSymbolTypesCount()
    {
        // Arrange
        string input = "Unit testing is the 1st step!!!";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            ["letters"] = 22,
            ["digits"] = 1,
            ["special characters"] = 3
        };

        // Act
        Dictionary<string, int> actual = SentenceAnalyzer.Analyze(input);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }
}

