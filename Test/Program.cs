string path = @"C:\TKTK";
string fileName = "chuck.txt";
string[] lines = File.ReadAllLines(Path.Combine(path, fileName));
Console.WriteLine(GetJoke(lines));

static string GetJoke(string[] jokeArray)
{
    Random rnd = new Random();
    return jokeArray[rnd.Next(9, jokeArray.Length)];
}