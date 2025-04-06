using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class AcronymGeneratorTests
{
    [Test]
    public void Test_GenerateAcronym_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        string expected = "";

        // Act
        string actual = AcronymGenerator.GenerateAcronym(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
        
    }

    [Test]
    public void Test_GenerateAcronym_SingleWord_ReturnsUpperCaseFirstLetter()
    {
        // Arrange
        string input = "a";
        string expected = "A";

        // Act
        string actual = AcronymGenerator.GenerateAcronym(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GenerateAcronym_MultipleWords_ReturnsUpperCaseFirstLetters()
    {
        // Arrange
        string input = "united states of america";
        string expected = "USA";

        // Act
        string actual = AcronymGenerator.GenerateAcronym(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GenerateAcronym_WordsWithNonLetters_ReturnsAcronymWithoutNonLetters()
    {
        // Arrange
        string input = "123 hello world!";
        string expected = "HW";

        // Act
        string actual = AcronymGenerator.GenerateAcronym(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GenerateAcronym_PhraseWithSpecialCharacters_ReturnsUpperCaseFirstLetters()
    {
        // Arrange
        string input = "intern@tion#l busine$$ mach*n&s";
        string expected = "IBM";

        // Act
        string actual = AcronymGenerator.GenerateAcronym(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
