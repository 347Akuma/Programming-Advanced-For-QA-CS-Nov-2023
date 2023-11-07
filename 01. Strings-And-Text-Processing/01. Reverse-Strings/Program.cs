string input;
while ((input = Console.ReadLine()) != "end")
{
    char[] currentWord = input.ToCharArray();
    Array.Reverse(currentWord);

    string reversedWord = new string (currentWord);

    Console.WriteLine($"{input} = {reversedWord}");
}
