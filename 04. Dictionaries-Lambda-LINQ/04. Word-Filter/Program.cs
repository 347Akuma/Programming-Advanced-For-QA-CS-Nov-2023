using System.Threading.Channels;

string[] words = Console.ReadLine().Split(" ").Where(x => x.Length % 2 == 0).ToArray();

foreach (string word in words)
{
    Console.WriteLine(word);
}

//foreach (string word in words)
//{
//    if (word.Length % 2 == 0)
//    {
//        Console.WriteLine(word);
//    }
//}
