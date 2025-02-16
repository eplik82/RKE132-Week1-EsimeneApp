Console.WriteLine("Sisesta number:");

int userNum = Convert.ToInt32(Console.ReadLine());

//Kas paaris või mitte

int result = userNum % 2;

//Console.WriteLine(result);

if(result != 0)
{
    Console.WriteLine("Number on paaritu");
}
else
{
    Console.WriteLine("Number on paaris");
}