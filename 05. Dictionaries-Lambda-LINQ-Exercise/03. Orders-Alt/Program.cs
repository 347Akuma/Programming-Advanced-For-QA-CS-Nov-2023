using System;
using System.Collections.Generic;


Dictionary<string, decimal> prices = new Dictionary<string, decimal>();
Dictionary<string, int> quantities = new Dictionary<string, int>();

string input;
while ((input = Console.ReadLine()) != "buy")
{
    string[] productInfo = input.Split();
    string productName = productInfo[0];
    decimal productPrice = decimal.Parse(productInfo[1]);
    int productQuantity = int.Parse(productInfo[2]);

    if (!prices.ContainsKey(productName))
    {
        prices[productName] = productPrice;
        quantities[productName] = productQuantity;
    }
    else
    {
        quantities[productName] += productQuantity;
        if (prices[productName] != productPrice)
        {
            prices[productName] = productPrice;
        }
    }
}

foreach (var product in prices)
{
    decimal totalPrice = prices[product.Key] * quantities[product.Key];
    Console.WriteLine($"{product.Key} -> {totalPrice:F2}");
}


