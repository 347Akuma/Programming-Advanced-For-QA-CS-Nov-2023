internal class Article
{
    // harakteristiki -> auto-properties -> automatically creates a private field -> gets + sets a value

    public string Title { get; set; } // creates a private string field called 'title' + get/set for access under Title property.
    public string Content { get; set; }
    public string Author { get; set; }


    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    // actions that can be performed with our Article: create Edit, ChangeAuthor, Rename, Override .ToString(); methods 
    public void Edit(string newContent)
    {
        Content = newContent; // prezapisvame sudurjanieto na Content s podadenoto newContent prieto ot metoda
    }

    public void ChangeAuthor (string newAuthor)
    {
        Author = newAuthor; // prezapisvame tekushtiq avtor na statiqta s podadeniq newAuthor kum metoda
    }

    public void Rename (string newTitle)
    {
        Title = newTitle;
    }

    public override string ToString() // rewrite .ToString's behavior and make it perform the below instead when called
    {
        return $"{Title} - {Content}: {Author}";
    }
}

