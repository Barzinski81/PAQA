using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
        

    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        // Arrange
        double initial = 150.00;

        // Act
        var actual = new BankAccount(initial);

        // Assert
        Assert.AreEqual(initial, actual.Balance);

    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        // Arrange
        double initial = 150.00;
        double deposit = 100.00;
        double expected = initial + deposit;

        // Act
        var actual = new BankAccount(initial);
        actual.Deposit(deposit);

        // Assert
        Assert.AreEqual(expected, actual.Balance);
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initial = 150.00;
        double deposit = -100.00;
        double expected = initial + deposit;
        var actual = new BankAccount(initial);

        // Act & Assert
        Assert.That(() => actual.Deposit(deposit), Throws.TypeOf<ArgumentException>());

    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        double initial = 150.00;
        double withdraw = 100.00;
        double expected = initial - withdraw;

        // Act
        var actual = new BankAccount(initial);
        actual.Withdraw(withdraw);

        // Assert
        Assert.AreEqual(expected, actual.Balance);
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initial = 150.00;
        double withdraw = -100.00;
        double expected = initial - withdraw;
        var actual = new BankAccount(initial);

        // Act & Assert
        Assert.That(() => actual.Withdraw(withdraw), Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        // Arrange
        double initial = 150.00;
        double withdraw = 200.00;
        double expected = initial - withdraw;
        var actual = new BankAccount(initial);

        // Act & Assert
        Assert.That(() => actual.Withdraw(withdraw), Throws.TypeOf<ArgumentException>());
    }
}
