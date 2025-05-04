// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the operation (+/-):");
char userOp = char.Parse(Console.ReadLine());

Console.WriteLine("Enter a:");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int SecondNum = int.Parse(Console.ReadLine());

switch (userOp)
{
    case '+':
        Add(firstNum, SecondNum);
        break;
    case '-':
        Sub(firstNum, SecondNum);
        break;
    default:
        Console.WriteLine("invalid operation");
        break;
}
static void Add(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Sub(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}