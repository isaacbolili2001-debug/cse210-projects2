using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        int choice = 0;
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
           string input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        BreathingActivity breathingActivity = new BreathingActivity();
                        breathingActivity.Run();
                        break;
                    case 2:
                        ReflectingActivity reflectingActivity = new ReflectingActivity();
                        reflectingActivity.Run();
                        break;
                    case 3:
                        ListingActivity listingActivity = new ListingActivity();
                        listingActivity.Run();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the Mindfulness Project. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
                Console.ReadLine();
            }
        }
    }
}