int n = int.Parse(Console.ReadLine()!);
var articles = new List<Article>();
for (int i = 0; i < n; i++)
{
    var p = Console.ReadLine()!.Split(", ");
    articles.Add(new Article(p[0], p[1], p[2]));
}
foreach (var a in articles) Console.WriteLine(a);

class Article
{
    public string Title { get; private set; }
    public string Content { get; private set; }
    public string Author { get; private set; }
    public Article(string title, string content, string author) { Title = title; Content = content; Author = author; }
    public override string ToString() => $"{Title} - {Content}: {Author}";
}
