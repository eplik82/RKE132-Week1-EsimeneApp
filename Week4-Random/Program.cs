//Random

Random rnd = new Random();

int myRandomNum;

int randomSum = 0;

for (int i = 0; i < 10; i++)
{
    myRandomNum = rnd.Next(0, 11);
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"Suvaline number on: {myRandomNum}");
    
}

Console.WriteLine($"Suvaline lõppsumma on: {randomSum}");