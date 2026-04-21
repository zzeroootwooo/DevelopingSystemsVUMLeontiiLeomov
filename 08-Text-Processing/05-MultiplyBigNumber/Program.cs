string num = Console.ReadLine()!.TrimStart('0');
int digit = int.Parse(Console.ReadLine()!);
if (digit == 0 || num.Length == 0) { Console.WriteLine(0); return; }
var result = new char[num.Length + 1];
int carry = 0;
for (int i = num.Length - 1; i >= 0; i--)
{
    int prod = (num[i] - '0') * digit + carry;
    result[i + 1] = (char)('0' + prod % 10);
    carry = prod / 10;
}
result[0] = (char)('0' + carry);
Console.WriteLine(new string(result).TrimStart('0'));
