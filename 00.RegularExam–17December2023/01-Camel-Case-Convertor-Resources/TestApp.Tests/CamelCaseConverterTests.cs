using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        string expected = "";

        // Act
        string actual = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        // Arrange
        string input = "text";
        string expected = "text";

        // Act
        string actual = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        // Arrange
        string input = "example text camel case";
        string expected = "exampleTextCamelCase";

        // Act
        string actual = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        // Arrange
        string input = "exAmplE Text CameL cAsE";
        string expected = "exampleTextCamelCase";

        // Act
        string actual = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
