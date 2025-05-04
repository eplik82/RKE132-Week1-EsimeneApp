// Functions
Console.WriteLine("Are you coming or leaving");
string userChoice = Console.ReadLine();

if(userChoice == "in")
{
    PrintHello();
}
else
{
    GoodBye();
}

static void PrintHello()
{
    Console.WriteLine("Hello, World!");
}

static void GoodBye()
{
    Console.WriteLine("Good bye");
}
