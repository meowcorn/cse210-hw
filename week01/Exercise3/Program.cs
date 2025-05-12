using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 8;
        Console.WriteLine("Hello World! This is the Exercise 3 Project.");
        int guess = 0;
     
        while (guess != magicNumber)
        {
            Console.WriteLine("Guess a number between 1 and 20.");
            guess = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your guess is: " + guess);
            if (guess < magicNumber)
                Console.WriteLine("Guess again higher.");
            if (guess > magicNumber)
                Console.WriteLine("Guess again lower");
            else if (guess == magicNumber)
                Console.WriteLine("You guessed the correct number!");
        }
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 21);
        int number = 0;
        while (number != randomNumber)
        {
            Console.WriteLine("Guess a number between 1 and 20.");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your guess is: " + number);
            if (number < randomNumber)
                Console.WriteLine("Guess again higher.");
            if (number > randomNumber)
                Console.WriteLine("Guess again lower");
            else if (number == randomNumber)
                Console.WriteLine("You guessed the correct number!");
        }
            
    }
}

