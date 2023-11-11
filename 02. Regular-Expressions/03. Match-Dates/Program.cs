using System.Text.RegularExpressions;

string pattern = @"\b(?<Day>\d{2})(?<sep>[\.\-\/])(?<Month>[A-Z][a-z]{2})\k<sep>(?<Year>\d{4})\b";

Regex regex = new Regex(pattern);

string text = Console.ReadLine();

MatchCollection matches = regex.Matches(text);


foreach (Match match in matches)
{
    Console.WriteLine($"{match.Groups[1].Name}: {match.Groups[1].Value}, {match.Groups[3].Name}: {match.Groups[3].Value}, {match.Groups[4].Name}: {match.Groups[4].Value}");
}