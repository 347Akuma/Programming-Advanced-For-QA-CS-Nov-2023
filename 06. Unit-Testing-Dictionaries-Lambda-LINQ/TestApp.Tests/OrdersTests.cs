using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        string[] input = Array.Empty<string>();

        string result = Orders.Order(input);    

        Assert.That(result, Is.Empty);
    }
   
    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[]{"apple 5.97 1","banana 3.75 1", "orange 1.98 1"  };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97\r\nbanana -> 3.75\r\norange -> 1.98"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 5.00 2", "banana 3.50 1", "orange 1.90 2" };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 10.00\r\nbanana -> 3.50\r\norange -> 3.80"));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 5.97 1.25", "banana 3.75 1.50", "orange 1.98 1.90" };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 7.46\r\nbanana -> 5.63\r\norange -> 3.76"));
    }
}
