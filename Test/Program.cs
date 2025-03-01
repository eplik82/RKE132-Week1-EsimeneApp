// See https://aka.ms/new-console-template for more information
Console.WriteLine("Mis hinde saite?");
char hinne = Convert.ToChar(Console.ReadLine().ToLower());

switch (hinne)
{
	case 'a':
		Console.WriteLine("Suurepärane!");
		break;
    case 'b':
        Console.WriteLine("Väga hea!");
        break;
    case 'c':
        Console.WriteLine("Hea!");
        break;
    case 'd':
        Console.WriteLine("Rahuldav");
        break;
    case 'e':
        Console.WriteLine("Kasin");
        break;
    case 'f':
        Console.WriteLine("Puudulik");
        break;
    default:
		Console.WriteLine("Vale väärtus");
        break;
}
