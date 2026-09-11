using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        ushort choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Save journal entries to a file");
            Console.WriteLine("4. Load journal entries from a file");
            Console.WriteLine("5. Quit");

            Console.Write("Enter your choice (1-5): ");
            choice = Convert.ToUInt16(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write(">");
                Console.Write("Enter your journal entry: ");
                string entryText = Console.ReadLine();

                DateTime currentDate = DateTime.Now;
                string dateText = currentDate.ToString();

                Entry newEntry = new Entry(dateText, prompt, entryText);
                theJournal.AddEntry(newEntry);
            }
            else if (choice == 2)
            {
                theJournal.DisplayEntries();
            }
            else if (choice == 3)
            {
                Console.Write("Enter the filename to save the journal entries: ");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("Enter the filename to load the journal entries from: ");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
                theJournal.DisplayEntries();
            }
            else if (choice == 5)
            {
                Console.WriteLine("Exiting the program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
            }


        }


    }
}

