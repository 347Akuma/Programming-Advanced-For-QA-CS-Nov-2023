string removeWord = Console.ReadLine();
string text = Console.ReadLine();

while (text.Contains(removeWord))
{
    // another alt:
    // text = text.Replace(removeWord, " ");
    int indexOfWordToRemove = text.IndexOf(removeWord);
    text = text.Remove(indexOfWordToRemove, removeWord.Length);
}

Console.WriteLine(text);

//Alt solution:
// int index = text.IndexOf(removeWord);
//while (index != -1)
//{
//    text = text.Remove(index, removeWord.Length);
//    index = text.IndexOf(removeWord);
//}
//Console.WriteLine(text);
