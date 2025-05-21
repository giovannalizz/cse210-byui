using System;



class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");

        bool running = true;

        while (running)
        {
            ShowMenu();

            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            Console.WriteLine();

            switch (userInput)
            {
                case "1":
                    journal.NewEntry();
                    Console.WriteLine();
                    break;

                case "2":
                    journal.DisplayEntries();
                    Console.WriteLine();
                    break;

                case "3":
                    Console.Write("Enter the file name to load (e.g., journal.csv): ");
                    string loadFile = Console.ReadLine();
                    journal.LoadEntries(loadFile);
                    Console.WriteLine();
                    break;

                case "4":
                    Console.Write("Enter the file name to save (e.g., journal.csv): ");
                    string saveFile = Console.ReadLine();
                    journal.SaveEntries(saveFile);
                    Console.WriteLine("Saved!\n");
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Thank you. Have a nice day!");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 5.\n");
                    break;
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write a new journal entry");
        Console.WriteLine("2. Display all journal entries");
        Console.WriteLine("3. Load journal entries from a file");
        Console.WriteLine("4. Save journal entries to a file");
        Console.WriteLine("5. Quit the program");
    }
}
