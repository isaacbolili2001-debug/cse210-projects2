using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11); // Generates a random number between 1 and 10

        Console.WriteLine("Please guess a number between 1 and 10: ");
        string input = Console.ReadLine();
        int guess = int.Parse(input);




        while (guess != number)
        {
            if (guess > number)
            {
                Console.WriteLine("go lower.");
            }
            else if (guess < number)
            {
                Console.WriteLine("go higher.");
            }

            Console.WriteLine("Please guess again: ");
            input = Console.ReadLine();
            guess = int.Parse(input);
        }

        Console.WriteLine($"Congratulations! You guessed the correct number: {number}");

    }
}