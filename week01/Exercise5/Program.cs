using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise 5 Project.");
        {
            DisplayWelcomeMessage();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int squareNumber = SquareNumber(userNumber);
            string userColor = PromptUserColor();
            DisplayUserInfo(userName, userNumber, squareNumber, userColor);
        }
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome! I'd like to get to know you.");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name?");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static string PromptUserColor()
        {
            Console.Write("What is your favorite color: ");
            string color = Console.ReadLine();
            return color;
        }
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        static void DisplayUserInfo(string name, int number, int square, string color)
        {
            Console.WriteLine($"Hello {name}, your favorite number is {number}.");
            Console.WriteLine($"The square of your favorite number is {square}.");
            Console.WriteLine($"Your favorite color is {color}.");
        }
    
        }
    }

