string pass = Console.ReadLine()!;
bool valid = true;
if (pass.Length < 6 || pass.Length > 10)
    { Console.WriteLine("Password must be between 6 and 10 characters"); valid = false; }
if (pass.Any(c => !char.IsLetterOrDigit(c)))
    { Console.WriteLine("Password must consist only of letters and digits"); valid = false; }
if (pass.Count(char.IsDigit) < 2)
    { Console.WriteLine("Password must have at least 2 digits"); valid = false; }
if (valid) Console.WriteLine("Password is valid");
