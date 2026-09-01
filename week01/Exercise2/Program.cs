using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("what is your grade? :");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";

        }
        else if (grade >= 80)
        {
            letter = "B";

        }
        else if (grade >= 70)
        {
            letter = "C";

        }
        else if (grade >= 60)
        {
            letter = "D";

        }
        else
        {
            letter = "F";

        }
        Console.WriteLine($"Your letter grade is: {letter}");
        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class.");
            Console.WriteLine("Better luck next time!");

        }

    }
}