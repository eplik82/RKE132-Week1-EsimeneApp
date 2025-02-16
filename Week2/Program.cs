// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Sisesta oma sugu m/n:");
char userGender = Char.Parse(Console.ReadLine());

Console.WriteLine("Palun sisestage oma perenimi:");
String userLastName = Console.ReadLine();

if(userGender == 'm')
{
    Console.WriteLine($"Tere Mr. {userLastName}!");
}
else if(userGender == 'n')
{
    Console.WriteLine($"Tere Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Tere {userLastName}!");
}