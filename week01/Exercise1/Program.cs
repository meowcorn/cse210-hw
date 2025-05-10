using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("This is in C#.");
        Console.Write("What is your favorite color?");
        string color = Console.ReadLine();
        Console.WriteLine($"Your favorite color is {color}.");
        Console.Write("What is your first name?");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name?");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your full name is {firstName} {lastName}.");
        Console.Write("What is your grade percentage?");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        if (percent >= 90)
        {
            Console.WriteLine("Congratulatons! You passed the class with an A.");
        }
        else if (percent >= 80)
        {
            Console.WriteLine("Great job! You passed the class with a B.");
        }
        else if (percent >= 70)
        {
            Console.WriteLine("Good work! You passed the class with a C.");
        }
        else if (percent >= 60)
        {
            Console.WriteLine("You earned a D. Joining a study group could help your grade.");
        }
        else
        {
            Console.WriteLine("Unfortunately you failed the class.");
        }
    }

}
    