

Console.WriteLine("Enter conversion method, to Farenheit or Celsius (f/c)");
char userOp = char.Parse(Console.ReadLine());


switch (userOp)
{
    case 'c':
        Console.WriteLine("Enter temp in Farenheits:");
        int Far = int.Parse(Console.ReadLine());
        ConverToCelsius(Far);
        break;
    case 'f':
        Console.WriteLine("Enter temp in Celsius:");
        int Cel = int.Parse(Console.ReadLine());
        ConvertToFahrenheit(Cel);
        break;
    default:
        Console.WriteLine("invalid operation, enter f or c");
        break;
}
static void ConverToCelsius(int temp)
{   int cel = (temp -32) * 5/9;
    Console.WriteLine($"{temp} Farenheits are {cel} in Celsius");
}

static void ConvertToFahrenheit(int temp)
{
    int far = (temp * 9) / 5 + 32;
    Console.WriteLine($"{temp} Celsius are {far} in Farenheits");
}