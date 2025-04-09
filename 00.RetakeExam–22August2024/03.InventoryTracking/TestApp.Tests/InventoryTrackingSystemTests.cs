using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

[TestFixture]
public class InventoryTrackingSystemTests
{
    private InventoryTrackingSystem _inventory = null!;

    [SetUp]
    public void SetUp()
    {
        _inventory = new InventoryTrackingSystem();
    }


    [Test]
    public void Test_Constructor_CheckInitialEmptyItemCollectionAndCount()
    {
        // Assert
        CollectionAssert.IsEmpty(_inventory.GetAllItems());
        Assert.That(_inventory.ItemCount, Is.EqualTo(0));
    }

    [Test]
    public void Test_AddItem_ValidItemName_AddNewItem()
    {
        // Arrange
        string item1 = "Item1";
        List<string> expected = new List<string>()
        {
            "Item1"
        };

        // Act
        _inventory.AddItem(item1);
        List<string> actual = _inventory.GetAllItems();

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [TestCase("")]
    [TestCase(null)]
    public void Test_AddItem_NullOrEmptyItemName_ThrowsArgumentException(string item)
    {
        // Assert
        Assert.That(() => _inventory.AddItem(item), Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void Test_RemoveItem_ValidItemName_RemoveFirstItemName()
    {
        // Arrange
        string item1 = "Item1";
        string item2 = "Item2";
        string item3 = "Item3";
        List<string> expected = new List<string>()
        {
            "Item2",
            "Item3"
        };

        // Act
        _inventory.AddItem(item1);
        _inventory.AddItem(item2);
        _inventory.AddItem(item3);
        _inventory.RemoveItem(item1);
        List<string> actual = _inventory.GetAllItems();

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [TestCase("")]
    [TestCase(null)]
    public void Test_RemoveItem_NullOrEmptyItemName_ThrowsArgumentException(string item)
    {
        // Arrange
        string item1 = "Item1";
        string item2 = "Item2";
        string item3 = "Item3";
        
        // Act
        _inventory.AddItem(item1);
        _inventory.AddItem(item2);
        _inventory.AddItem(item3);
       
        // Assert
        Assert.That(() => _inventory.RemoveItem(item), Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void Test_GetAllItems_AddedAndRemovedItems_ReturnsExpectedItemCollection()
    {
        // Arrange
        string item1 = "Item1";
        string item2 = "Item2";
        string item3 = "Item3";
        string item4 = "Item4";
        string item5 = "Item5";
        List<string> expected = new List<string>()
        {
            "Item2",
            "Item3"
        };

        // Act
        _inventory.AddItem(item1);
        _inventory.AddItem(item2);
        _inventory.AddItem(item3);
        _inventory.AddItem(item4);
        _inventory.AddItem(item5);
        _inventory.RemoveItem(item1);
        _inventory.RemoveItem(item4);
        _inventory.RemoveItem(item5);
        List<string> actual = _inventory.GetAllItems();

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }
}
