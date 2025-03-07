using NUnit.Framework;

using System.Collections.Generic;
using static System.Net.WebRequestMethods;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";
        List<string> expected = new List<string>();

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "http test text url";
        List<string> expected = new List<string>();

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = "http test https://softuni.bg text url";
        List<string> expected = new List<string>() { "https://softuni.bg"};

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = "http test https://softuni.bg text https://regex101.com url https://www.facebook.com";
        List<string> expected = new List<string>() { "https://softuni.bg", "https://regex101.com", "https://www.facebook.com" };

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "http www test https://www.technopolis.bg?utm_source= text https://regex101.com url http.website.bg https://onlineshop.bg?search";
        List<string> expected = new List<string>() { "https://www.technopolis.bg?utm_source=", "https://regex101.com", "https://onlineshop.bg?search" };

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }
}
