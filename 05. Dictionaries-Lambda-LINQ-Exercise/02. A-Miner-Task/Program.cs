Dictionary<string, int> resources = new Dictionary<string, int>();


string input;
while ((input = Console.ReadLine()) != "stop")
{
    int materialquantity = int.Parse(Console.ReadLine());

    if (resources.ContainsKey(input))
    {
        resources[input] += materialquantity;
    }
    else
    {
        resources.Add(input, materialquantity);
    }  
}
foreach (KeyValuePair<string, int> kvp in resources)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}