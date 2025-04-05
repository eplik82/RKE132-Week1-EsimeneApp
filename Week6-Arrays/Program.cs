// Array   
//string[] fruit = { "aplle", "banana", "orange" };

string[] fruit = new string[3];

fruit[0] = "apple";
fruit[1] = "banana";
fruit[2] = "orange";

Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLength = fruit.Length;

Console.WriteLine($"There are {fruitArrayLength} fruit in your array");

foreach( string element in fruit)
{
    Console.WriteLine( element );
}
