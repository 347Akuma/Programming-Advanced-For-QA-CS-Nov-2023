string[] words = Console.ReadLine().Split(" ");

Dictionary<string, int> occuranceCount = new();

foreach (string word in words)
{
    string caseInsensitiveWord = word.ToLower();

    if (occuranceCount.ContainsKey(caseInsensitiveWord))
    {
        occuranceCount[caseInsensitiveWord]++;
    }
    else
    {
        occuranceCount.Add(caseInsensitiveWord, 1);
    }
}

foreach (KeyValuePair<string, int> pair in occuranceCount)
{
    if (pair.Value % 2 != 0)
    {
        Console.Write($"{pair.Key} ");
    }
}