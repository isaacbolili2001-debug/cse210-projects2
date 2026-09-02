using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();

        Console.Write("Please enter a number: ");
        string userinput = Console.ReadLine();
        int number = int.Parse(userinput);

        // Keep asking for numbers until the user enters 0
        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Please enter a number: ");
            userinput = Console.ReadLine();
            number = int.Parse(userinput);
        }


        // Calculate the sum, largest number, and average of the numbers entered
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");

        int largest = numbers[0];
        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average:F2}");
    }
}