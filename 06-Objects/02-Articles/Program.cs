var parts = Console.ReadLine()!.Split(", ");
var article = new Article(parts[0], parts[1], parts[2]);
int n = int.Parse(Console.ReadLine()!);
for (int i = 0; i < n; i++)
{
    var line = Console.ReadLine()!;
    var idx = line.IndexOf(": ");
    var cmd = line[..idx];
    var arg = line[(idx + 2)..];
    if (cmd == "Edit") article.Edit(arg);
    else if (cmd == "ChangeAuthor") article.ChangeAuthor(arg);
    else if (cmd == "Rename") article.Rename(arg);
}
Console.WriteLine(article);

class Article
{
    public string Title { get; private set; }
    public string Content { get; private set; }
    public string Author { get; private set; }
    public Article(string title, string content, string author) { Title = title; Content = content; Author = author; }
    public void Edit(string newContent) => Content = newContent;
    public void ChangeAuthor(string newAuthor) => Author = newAuthor;
    public void Rename(string newTitle) => Title = newTitle;
    public override string ToString() => $"{Title} - {Content}: {Author}";
}
