//string[] heros = {"Harry Potter","Lara Craft","Luke Skywalker","Scooby-Doo"};
//string[] villains = { "Voldemort", "Darth Vader", "Dracula", "Joker", "Sauron" };
string folderPath = @"C:\TKTK\";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heros = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));

string[] weapons = { "magic wand", "plastic fork", "banana", "wooden sword", "Lego brick" };

string hero = GetRandom(heros);
string heroWeapon = GetRandom(weapons);
int heroHP = GetCharacterHP(hero);
int heroStrikeStrength = heroHP;
Console.WriteLine($"Your hero is {hero} ({heroHP} HP), with {heroWeapon}");

string villain = GetRandom(villains);
string villiainWeapon = GetRandom(weapons);
int villainHP = GetCharacterHP(villain);
int villainStrikeStrength = villainHP;
Console.WriteLine($"Your Villain is {villain} ({villainHP} HP) with {villiainWeapon}");

while(heroHP > 0 && villainHP > 0)
{
    heroHP = heroHP - Hit(villain, villainStrikeStrength);
    villainHP = villainHP - Hit(hero, heroStrikeStrength);
}

Console.WriteLine($"Hero {hero} HP: {heroHP}");
Console.WriteLine($"Villain {villain} HP: {villainHP}");

if (heroHP > 0)
{
    Console.WriteLine($"{hero} saved the day!");
}
else if(villainHP > 0)
{
    Console.WriteLine($"{villain} destroyed the day!");
}
else
{
    Console.WriteLine("Draw!");
}

static string GetRandom(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}

static int GetCharacterHP(string characterName)
{
    if (characterName.Length < 10)
    {
        return 10;
    }
    else
    {
        return characterName.Length;
    }
}

static int Hit(string charName, int characterHP)
{
    Random rnd = new Random();
    int strike = rnd.Next(0, characterHP);

    if (strike == 0)
    {
        Console.WriteLine($"Your character {charName} missed the target!");
    }
    else if (strike == characterHP -1) 
    {
        Console.WriteLine($" {charName} made a critical hit!");
    }
    else
    {
        Console.WriteLine($" {charName} hit {strike}!");
    }

    return strike;
}