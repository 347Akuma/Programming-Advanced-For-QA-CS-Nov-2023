using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        // Arrange
        double initialBalance = 100.0;

        // Act
        BankAccount account = new BankAccount(initialBalance);

        // Assert
        Assert.AreEqual(initialBalance, account.Balance);
    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        // Arrange
        BankAccount account = new BankAccount(100.0);
        double depositAmount = 50.0;
        double expectedBalance = account.Balance + depositAmount;

        // Act
        account.Deposit(depositAmount);

        // Assert
        Assert.AreEqual(expectedBalance, account.Balance);
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        BankAccount account = new BankAccount(100.0);
        double negativeAmount = -50.0;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => account.Deposit(negativeAmount));
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        BankAccount account = new BankAccount(100.0);
        double withdrawalAmount = 50.0;
        double expectedBalance = account.Balance - withdrawalAmount;

        // Act
        account.Withdraw(withdrawalAmount);

        // Assert
        Assert.AreEqual(expectedBalance, account.Balance);
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        BankAccount account = new BankAccount(100.0);
        double negativeAmount = -50.0;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => account.Withdraw(negativeAmount));
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        // Arrange
        BankAccount account = new BankAccount(100.0);
        double withdrawalAmount = 150.0;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => account.Withdraw(withdrawalAmount));
    }
}
