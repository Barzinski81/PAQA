using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[] { };
        // Act
        string actual = Orders.Order(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 1.99 3", "banana 1.25 3", "orange 0.99 2"};
        // Act
        string actual = Orders.Order(input);

        // Assert
        Assert.That(actual, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 2.00 3", "banana 1.20 3", "orange 1.00 2" };
        // Act
        string actual = Orders.Order(input);

        // Assert
        Assert.That(actual, Is.EqualTo($"apple -> 6.00{Environment.NewLine}banana -> 3.60{Environment.NewLine}orange -> 2.00"));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 2.00 3.16", "banana 1.20 3.58", "orange 1.00 2.23" };
        // Act
        string actual = Orders.Order(input);

        // Assert
        Assert.That(actual, Is.EqualTo($"apple -> 6.32{Environment.NewLine}banana -> 4.30{Environment.NewLine}orange -> 2.23"));
    }
}
