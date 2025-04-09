using System;
using System.Diagnostics;
using System.Xml.Linq;
using NUnit.Framework;

using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        string name = "Product1";
        double price = 50.00;
        int quantity = 5;
        string expected = "Product Inventory:"
                         +Environment.NewLine
                         +"Product1 - Price: $50.00 - Quantity: 5";

        // Act
        _inventory.AddProduct(name, price, quantity);
        string actual = _inventory.DisplayInventory();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Arrange
        string expected = "Product Inventory:";

        // Act
        string actual = _inventory.DisplayInventory();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        string name1 = "Product1";
        double price1 = 50.00;
        int quantity1 = 5;

        string name2 = "Product2";
        double price2 = 500.00;
        int quantity2 = 3;

        string name3 = "Product3";
        double price3 = 25.00;
        int quantity3 = 10;

        string expected = "Product Inventory:"
                         + Environment.NewLine
                         + "Product1 - Price: $50.00 - Quantity: 5"
                         + Environment.NewLine
                         + "Product2 - Price: $500.00 - Quantity: 3"
                         + Environment.NewLine
                         + "Product3 - Price: $25.00 - Quantity: 10";
        // Act
        _inventory.AddProduct(name1, price1, quantity1);
        _inventory.AddProduct(name2, price2, quantity2);
        _inventory.AddProduct(name3, price3, quantity3);
        string actual = _inventory.DisplayInventory();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Arrange
        double expected = 0.00;

        // Act
        double actual = _inventory.CalculateTotalValue();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        string name1 = "Product1";
        double price1 = 50.00;
        int quantity1 = 5;

        string name2 = "Product2";
        double price2 = 500.00;
        int quantity2 = 3;

        string name3 = "Product3";
        double price3 = 25.00;
        int quantity3 = 10;

        double expected = 2000.00;

        // Act
        _inventory.AddProduct(name1, price1, quantity1);
        _inventory.AddProduct(name2, price2, quantity2);
        _inventory.AddProduct(name3, price3, quantity3);

        double actual = _inventory.CalculateTotalValue();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
