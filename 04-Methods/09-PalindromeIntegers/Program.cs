string? line;
while ((line = Console.ReadLine()) != "END")
{
    string rev = new string(line!.Reverse().ToArray());
    Console.WriteLine(line == rev);
}
