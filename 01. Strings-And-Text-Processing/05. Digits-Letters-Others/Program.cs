using System.Text;

string text = Console.ReadLine();

StringBuilder num = new StringBuilder();
StringBuilder let = new StringBuilder();
StringBuilder ch = new StringBuilder();

for (int i = 0; i < text.Length; i++)
{
    char current = text[i];

    if (char.IsDigit(current))
    {
        num.Append(current);
    }
    else if (char.IsLetter(current))
    {
        let.Append(current);
    }
    else
    {        
        ch.Append(current);
    }
}
Console.WriteLine($"{num}\n{let}\n{ch}");