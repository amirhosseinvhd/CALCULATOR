
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

int Number1 = 0;
int Number2 = 0;
char Action = '=';
Console.WriteLine("Please enter number One");
Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number Two");
Number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter action + - * /");
Action = Convert.ToChar(Console.ReadLine());
if (Action == '+')
{
    Console.WriteLine(Number1 + Number2);
}
else if (Action == '-')
{
    Console.WriteLine(Number1 - Number2);
}
else if (Action == '*')
{
    Console.WriteLine(Number1 * Number2);
}
else if (Action == '/')
{
    Console.WriteLine(Number1 / Number2);
}
else
{
    Console.WriteLine("Please enter only action");
}



Console.ReadKey();

