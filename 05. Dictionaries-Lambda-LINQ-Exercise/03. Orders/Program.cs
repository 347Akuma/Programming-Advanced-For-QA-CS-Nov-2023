Dictionary<string, double> price = new Dictionary<string, double>();

Dictionary<string, double> quantity = new Dictionary<string, double>();

string input;
while ((input = Console.ReadLine()) != "buy")
{
    List<string> productInfo = input.Split(" ").ToList();
    string productName = productInfo[0];
    double productPrice = double.Parse(productInfo[1]);
    int productQuantity = int.Parse(productInfo[2]);

    // check if product exists in the product Dict. first
    if (price.ContainsKey(productName))
    {
        //if it does, update it's quantity in the second Dict (in both cases).
        quantity[productName] += productQuantity;

        // since product already exists, compare it's value to the new input price
        if (price[productName] != productPrice)
        {
            // if it's different, update it's price with the new one
            price[productName] = productPrice;
        }       
    }
    else
    {
        // if it doesn't exist yet, add it to both Dict. with the input values
        price.Add(productName, productPrice);
        quantity.Add(productName, productQuantity);
    }
}

foreach (KeyValuePair<string, double> product in price)
{
    // calculate the total price of each product by taking it's price and quantity values from both Dict.
    double totalPrice = price[product.Key] * quantity[product.Key];
    Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
}