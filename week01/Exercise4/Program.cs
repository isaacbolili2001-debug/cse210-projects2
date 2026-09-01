using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        Random randomGenerator = new Random();
        for (int i = 0; i < 10; i++)
        {
            int number = randomGenerator.Next(1, 101); // Generates a random number between 1 and 100
            numbers.Add(number);
        }
        Console.WriteLine("The generated numbers are:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}