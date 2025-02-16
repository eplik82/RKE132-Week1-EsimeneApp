// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sisesta vanus:");

String userAge = Console.ReadLine();
int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

if (isAgeNumber == true)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Teretulemast lehele!");
    }
    else
    {
        Console.WriteLine("Kahjuks liiga noor");

    }
}
else
{
    Console.WriteLine("Sisestage number");
}