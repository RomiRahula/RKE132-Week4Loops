
using System.Diagnostics.CodeAnalysis;

int sum = 0;


for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"i ={i}");
    Console.WriteLine($"Current Total: {sum}");
    sum = sum + i;
}
Console.WriteLine($" Final Total {sum}");
