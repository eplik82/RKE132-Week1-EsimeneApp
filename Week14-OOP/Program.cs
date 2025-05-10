Console.WriteLine("Nimeta koer");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);
Dog NDog = new Dog("Ikka naabri koer");

Console.WriteLine($"My dog name is {myDog.Name}");
Console.WriteLine($"My Nei.dog name is {NDog.Name}");

myDog.Rename("Bad boy");
//Console.WriteLine($"Level of hapines: {myDog.LevelOfHapiness}");

//myDog.Bark();
//Console.WriteLine($"Level of hapines: {myDog.LevelOfHapiness}");
while(myDog.LevelOfHapiness != 5)
{
    myDog.Bark();
}

myDog.WigTail();

class Dog
{
    private string _name;
    private int _levelOfHapiness;

    //Constructor
    public Dog(string name)
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    //getter

    public string Name
    {
        get { return _name; }
    }
    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; } 
    }



    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Auh-Auh");
        _levelOfHapiness++;
    }

    public void WigTail()
    {
        Console.WriteLine("Wiggle-Wiggle");
    }
}