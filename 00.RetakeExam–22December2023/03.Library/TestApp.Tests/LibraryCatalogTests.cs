using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using TestApp.Library;

namespace TestApp.Tests;

[TestFixture]
public class LibraryCatalogTests
{
    private LibraryCatalog _catalog = null!;

    [SetUp]
    public void SetUp()
    {
        this._catalog = new();
    }

    [Test]
    public void Test_AddBook_BookAddedToCatalog()
    {
        // Arrange 
        string isbn = "111-111";
        string title = "Title One";
        string author = "First Author";

        // Act 
        _catalog.AddBook(isbn, title, author);
        Book actual = _catalog.GetBook(isbn);

        // Assert
        Assert.AreEqual(isbn, actual.Isbn);
        Assert.AreEqual(title, actual.Title);
        Assert.AreEqual(author, actual.Author);

    }

    [Test]
    public void Test_GetBook_BookExists_ReturnsBook()
    {
        // Arrange 
        string isbn = "111-111";
        string title = "Title One";
        string author = "First Author";

        // Act 
        _catalog.AddBook(isbn, title, author);
        Book actual = _catalog.GetBook(isbn);

        // Assert
        Assert.AreEqual(isbn, actual.Isbn);
        Assert.AreEqual(title, actual.Title);
        Assert.AreEqual(author, actual.Author);
    }

    [Test]
    public void Test_GetBook_BookDoesNotExist_ThrowsArgumentException()
    {
        // Arrange 
        string isbn = "111-111";
        string title = "Title One";
        string author = "First Author";

        // Act & Assert
        Assert.That(() => this._catalog.GetBook(isbn), Throws.TypeOf<ArgumentException>());

    }   

    [Test]
    public void Test_DisplayCatalog_NoBooks_ReturnsEmptyString()
    {
        // Act
        string actual = this._catalog.DisplayCatalog();

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_DisplayCatalog_WithBooks_ReturnsFormattedCatalog()
    {
        // Arrange
        // Arrange 
        string isbn = "111-111";
        string title = "Title One";
        string author = "First Author";
        _catalog.AddBook(isbn, title, author);
        string expected = "Library Catalog:"
                         +Environment.NewLine
                         +"Title One by First Author (ISBN: 111-111)";

        // Act
        string actual = this._catalog.DisplayCatalog();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
