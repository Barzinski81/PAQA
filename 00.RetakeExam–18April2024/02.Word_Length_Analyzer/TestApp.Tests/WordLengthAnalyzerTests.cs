using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class WordLengthAnalyzerTests
{
    [Test]
    public void Test_AnalyzeSentence_EmptyString_ReturnsEmptyDictionary()
    {
        // Arrange
        string input = "";
        Dictionary<string, int> expected = new Dictionary<string, int>() { };

        // Act
        Dictionary<string, int> actual = WordLengthAnalyzer.AnalyzeSentence(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_AnalyzeSentence_InvalidWordsWithDigits_ReturnsEmptyDictionary()
    {
        // Arrange
        string input = "Qu@lity assur@nc3 c0urses 0f S0ftUn1 ar3 th3 b3st!";
        Dictionary<string, int> expected = new Dictionary<string, int>(){ };

        // Act
        Dictionary<string, int> actual = WordLengthAnalyzer.AnalyzeSentence(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_AnalyzeSentence_WordsWithDifferentThanLetterSymbols_ReturnsDictionaryOnlyWithValidWordTypesCount()
    {
        // Arrange
        string input = "Qual1ty assurance cours3s of SoftUni ar3 the best!";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            {"short", 3 },
            {"medium", 1 },
            {"long", 1 }
        };

        // Act
        Dictionary<string, int> actual = WordLengthAnalyzer.AnalyzeSentence(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_AnalyzeSentence_WholeSentenceWithValidWords_ReturnsAllTypeOfWordsWithCorrectCount()
    {
        // Arrange
        string input = "Quality assurance courses of SoftUni are the best!";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            {"short", 4 },
            {"medium", 3 },
            {"long", 1 }
        };

        // Act
        Dictionary<string, int> actual = WordLengthAnalyzer.AnalyzeSentence(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}

