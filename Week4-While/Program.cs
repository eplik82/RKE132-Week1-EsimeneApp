Random rnd = new Random();
int cpuRandom;

bool loopActive = true;

while (loopActive)
{
    cpuRandom = rnd.Next(1,4);
    Console.WriteLine($"Arva number (1-3)");
    int userNum = Int32.Parse( Console.ReadLine() );
    Console.WriteLine($"Arvuti genereeris: {cpuRandom}");

    if (userNum == cpuRandom)
    {
        Console.WriteLine("Palju õnne, võitsid");
        loopActive = false; 
    }
    else
    {
        Console.WriteLine("Proovi veel");
    }

}

Console.WriteLine("Kena päeva");