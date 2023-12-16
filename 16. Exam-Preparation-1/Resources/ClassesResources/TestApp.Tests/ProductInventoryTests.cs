using NUnit.Framework;
using System;
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
        //Arrange
        string productName = "Banana";
        double productPrice = 100;
        int quantity = 10;

        string expectedInventory = $"Product Inventory:{Environment.NewLine}" +
            $"{productName} - Price: ${productPrice:f2} - Quantity: {quantity}";

        //Act
        this._inventory.AddProduct(productName, productPrice, quantity);
        string result = this._inventory.DisplayInventory();

        //Assert
        Assert.AreEqual(expectedInventory, result); 
        
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        //Arrange
        string expected = $"Product Inventory:";

        //Act
        string result = this._inventory.DisplayInventory();

        //Assert
        Assert.AreEqual (expected, result);
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        //Arrange
        string product1 = "Tuna";
        double price1 = 100;
        int quantity1 = 10;

        string product2 = "Rice";
        double price2 = 10;
        int quantity2 = 5;

        string expected = $"Product Inventory:" +
                          $"{Environment.NewLine}" +
                          $"{product1} - Price: ${price1:f2} - Quantity: {quantity1}" +
                          $"{Environment.NewLine}"+
                          $"{product2} - Price: ${price2:f2} - Quantity: {quantity2}";

        //Act
        this._inventory.AddProduct(product1, price1, quantity1);
        this._inventory.AddProduct(product2, price2, quantity2);

        string result = this._inventory.DisplayInventory();

        //Assert
        Assert.AreEqual(expected, result);

    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        //Arrange
        //Act
        double result = this._inventory.CalculateTotalValue();

        //Assert
        Assert.That(result, Is.Zero);
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        //Arrange
        string product1 = "Tuna";
        double price1 = 100;
        int quantity1 = 10;

        string product2 = "Rice";
        double price2 = 10;
        int quantity2 = 5;

        //Act
        this._inventory.AddProduct(product1, price1, quantity1);
        this._inventory.AddProduct(product2, price2, quantity2);

        double result = this._inventory.CalculateTotalValue();

        //Assert
        Assert.AreEqual((double)1050, result);
    }
}
