using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        string expected = "";
        int positions = 0;

        // Act
        string actual = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "hello";
        string expected = "hello";
        int positions = 0;

        // Act
        string actual = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "abcdef";
        string expected = "efabcd";
        int positions = 2;

        // Act
        string actual = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "abcdef";
        string expected = "efabcd";
        int positions = -2;

        // Act
        string actual = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "abcdef";
        string expected = "fabcde";
        int positions = 7;

        // Act
        string actual = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
