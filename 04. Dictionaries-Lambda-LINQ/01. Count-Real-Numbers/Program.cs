string[] numbers = Console.ReadLine().Split(" ");

Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

Array.Sort(numbers);

foreach (string number in numbers)
{
    if (keyValuePairs.ContainsKey(number))
    {
        keyValuePairs[number] += 1;
    }
    else
    {
        keyValuePairs.Add(number, 1);
    }
}
foreach (KeyValuePair<string, int> pair in keyValuePairs)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}