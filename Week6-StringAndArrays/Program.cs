string hello = "Hello, world! ";

int stringLength = hello.Length;

//Console.WriteLine(stringLength);
hello = hello.Trim();

int wordCounter = 1;

for (int i = 0; i < hello.Length; i++)
{
    if (char.IsWhiteSpace(hello[i]))
    {
        wordCounter++;
    }
}

Console.WriteLine($"Word count in {hello}: {wordCounter} words");
