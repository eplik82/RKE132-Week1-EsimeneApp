﻿//Arg&Par

Console.WriteLine("Enter a word");
string userInput = Console.ReadLine();

PrintAnyWord(userInput);
static void PrintAnyWord(string word)
{
    word = word.ToUpper();
        for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(word);
    }
}