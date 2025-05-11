using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("This is in C#.");
        Console.Write("What is your favorite color?");
        string color = Console.ReadLine();
        Console.WriteLine($"Your favorite color is {color}.");
        Console.Write("What is your first name?");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name?");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your full name is {firstName} {lastName}.");
        
    }

}
    