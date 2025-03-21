using NUnit.Framework;

using System;
using System.Reflection.Metadata;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;

    [SetUp]
    public void SetUp()
    {
        this._article = new();
    }

    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] input = { "Article1 Content1 Author1",
                           "Article2 Content2 Author2",
                           "Article3 Content3 Author3" };
        // Act
        Article actual = this._article.AddArticles(input);

        // Assert
        Assert.That(actual.ArticleList, Has.Count.EqualTo(3));
        Assert.That(actual.ArticleList[0].Title, Is.EqualTo("Article1"));
        Assert.That(actual.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(actual.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        _article.ArticleList.Add(new Article
        {
            Title = "Article1",
            Content = "Content1",
            Author = "Author1"
        });
        _article.ArticleList.Add(new Article
        {
            Title = "Article3",
            Content = "Content3",
            Author = "Author3"
        });
        _article.ArticleList.Add(new Article
        {
            Title = "Article2",
            Content = "Content2",
            Author = "Author2"
        });

        string print = "title";

        string expected = "Article1 - Content1: Author1"
                        + Environment.NewLine
                        + "Article2 - Content2: Author2"
                        + Environment.NewLine
                        + "Article3 - Content3: Author3";

        // Act
        string actual = _article.GetArticleList(_article, print);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        _article.ArticleList.Add(new Article
        {
            Title = "Article1",
            Content = "Content1",
            Author = "Author1"
        });
        _article.ArticleList.Add(new Article
        {
            Title = "Article3",
            Content = "Content3",
            Author = "Author3"
        });
        _article.ArticleList.Add(new Article
        {
            Title = "Article2",
            Content = "Content2",
            Author = "Author2"
        });

        string print = "error";

        string expected ="";

        // Act
        string actual = _article.GetArticleList(_article, print);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
