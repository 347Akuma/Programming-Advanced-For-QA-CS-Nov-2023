string text = Console.ReadLine();

char[] breakdown = text.ToCharArray();



Dictionary<char, int> occurrances = new Dictionary<char, int>();

foreach (char c in breakdown)
{
    if (char.IsWhiteSpace(c))
    {
        continue;
    }
    
    if (occurrances.ContainsKey(c))
    {
        occurrances[c]++;
    }
    else
    {
        occurrances.Add(c, 1);
    }
}
foreach (KeyValuePair<char, int> oc in occurrances)
{
    Console.WriteLine($"{oc.Key} -> {oc.Value}");
}


