string[] input = Console.ReadLine().Split();

foreach (string line in input)
{
    for (int i = 0; i < line.Length; i++)
    {
        Console.Write(line);
    }
}
