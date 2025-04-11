using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        // Arrange
        string input = "";
        string[] expected = { };

        // Act
        string[] actual = CsvParser.ParseCsv(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        // Arrange
        string input = "Name";
        string[] expected = { "Name" };

        // Act
        string[] actual = CsvParser.ParseCsv(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        // Arrange
        string input = "Name, Family, Town, Area";
        string[] expected = { "Name", "Family", "Town", "Area" };

        // Act
        string[] actual = CsvParser.ParseCsv(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        // Arrange
        string input = "Name  , Family , Town  , Area  ";
        string[] expected = { "Name", "Family", "Town", "Area" };

        // Act
        string[] actual = CsvParser.ParseCsv(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }
}
