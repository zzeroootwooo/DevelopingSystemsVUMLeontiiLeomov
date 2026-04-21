string path = Console.ReadLine()!;
int lastSlash = path.LastIndexOf('\\');
string fileName = path[(lastSlash + 1)..];
int dot = fileName.LastIndexOf('.');
Console.WriteLine($"File name: {fileName[..dot]}");
Console.WriteLine($"File extension: {fileName[(dot + 1)..]}");
