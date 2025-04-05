// OR

using System.ComponentModel.Design;

int math, biology, chemistry;

Console.WriteLine("Enter math result");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter biology result");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter chemistry result");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && biology >= 90) || (math >= 90 && chemistry >= 90) || (biology >= 90 && chemistry >= 90))
{
    Console.WriteLine("Congratulation! You got accepted");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}
