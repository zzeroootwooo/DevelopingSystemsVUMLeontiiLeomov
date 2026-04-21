string username = Console.ReadLine()!;
string correct = new string(username.Reverse().ToArray());
for (int i = 0; i < 4; i++)
{
    string pass = Console.ReadLine()!;
    if (pass == correct) { Console.WriteLine($"User {username} logged in."); return; }
    if (i < 3) Console.WriteLine("Incorrect password. Try again.");
}
Console.WriteLine($"User {username} blocked!");
