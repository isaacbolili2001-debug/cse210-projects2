using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text = "Trust in the lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths";

        Scripture scripture = new Scripture(reference, text);

        string userInput = "";

        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayTextString());
            Console.WriteLine();


            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit: ");
            userInput = Console.ReadLine();

            if (userInput == null)
            {
                break;
            }

            userInput = userInput.Trim().ToLower();

            if (userInput != "qui")
            {
                scripture.HideRandomWords(3);
            }


        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayTextString());
        Console.WriteLine("\nProgram ended. Good job Memorizing! ");

    }
}