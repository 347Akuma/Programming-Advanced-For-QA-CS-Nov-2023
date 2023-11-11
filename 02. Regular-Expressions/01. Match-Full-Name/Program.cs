using System.Text.RegularExpressions;

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

Regex regex = new Regex(pattern);

string text = Console.ReadLine();

MatchCollection matches = regex.Matches(text);


foreach (Match match in matches)
{
    Console.Write(match.Value + " ");
}

