string[] articleData = Console.ReadLine().Split(", ");
int numberOfCommands = int.Parse(Console.ReadLine());

string title = articleData[0];
string content = articleData[1];
string author = articleData[2];

Article article = new Article(title, content, author);

for (int i = 1; i <= numberOfCommands; i++)
{
    string[] command = Console.ReadLine().Split(": ");

    string action = command[0];
    string parameter = command[1];

    switch (action) // pri vseki sluchai si vikame metodcheto
    {
        case "Edit":
            article.Edit(parameter);
            break;
        case "ChangeAuthor":
            article.ChangeAuthor(parameter);
            break;
        case "Rename":
            article.Rename(parameter);
            break;
    }
}

// printer

Console.WriteLine(article.ToString());
