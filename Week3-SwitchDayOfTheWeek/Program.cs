

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

switch (weekDay)
{
    case 0:
        Console.WriteLine("Täna on pühapäev");
	    break;
    case 1:
        Console.WriteLine("Täna on esmaspäev");
        break;
    case 2:
        Console.WriteLine("Täna on teisipäev");
        break;
    case 3:
        Console.WriteLine("Täna on kolmapäev");
        break;
    case 4:
        Console.WriteLine("Täna on neljapäev");
        break;
    case 5:
        Console.WriteLine("Täna on reede");
        break;
    case 6:
        Console.WriteLine("Täna on laupäev");
        break;
    default:
        Console.WriteLine("Midagi läks katki");
        break;
}

Console.WriteLine("Kena päeva!");