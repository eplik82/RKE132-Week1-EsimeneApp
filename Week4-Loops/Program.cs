//For loop

int sum = 0;

for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"i = {i + 1}");
    Console.WriteLine($"Hetke summa: {sum}");
    sum = sum + i;
}

Console.WriteLine($"Lõppsumma: {sum}");