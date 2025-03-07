using System;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    // TODO: finish the test
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        string dates = "31-May-1986";
        string expected = "Day: 31, Month: May, Year: 1986";

        // Act
        string actual = MatchDates.Match(dates);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string dates = "12 Jun.1982 31/May.1986 12.Jun-1982";
        string expected = "";

        // Act
        string actual = MatchDates.Match(dates);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        // Arrange
        string dates = "31-May-1986 12.Jun.1982 10.May.1996 29-Dec-1994";
        string expected = "Day: 31, Month: May, Year: 1986";

        // Act
        string actual = MatchDates.Match(dates);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string dates = "";
        string expected = "";

        // Act
        string actual = MatchDates.Match(dates);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        // Arrange
        string dates = null;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => MatchDates.Match(dates));

    }
}
