using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] banned = new string[] { };
        string text = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown fox jumps over the lazy dog";

        // Act
        string actual = TextFilter.Filter(banned, text);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] banned = new string[] { "jumps", "quick", "dog" };
        string text = "The quick brown fox jumps over the lazy dog";
        string expected = "The ***** brown fox ***** over the lazy ***";

        // Act
        string actual = TextFilter.Filter(banned, text);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] banned = Array.Empty<string>();
        string text = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown fox jumps over the lazy dog";

        // Act
        string actual = TextFilter.Filter(banned, text);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] banned = new string[] { " " };
        string text = "The quick brown fox jumps over the lazy dog";
        string expected = "The*quick*brown*fox*jumps*over*the*lazy*dog";

        // Act
        string actual = TextFilter.Filter(banned, text);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }
}
