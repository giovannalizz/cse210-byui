using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "scriptures.txt";
        string[] lines = File.ReadAllLines(filePath);

        if (lines.Length == 0)
        {
            Console.WriteLine("No scriptures found in file.");
            return;
        }

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Reference reference;
            string text;

            if (parts.Length == 5)
            {
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int startVerse = int.Parse(parts[2]);
                int endVerse = int.Parse(parts[3]);
                text = parts[4];
                reference = new Reference(book, chapter, startVerse, endVerse);
            }
            else if (parts.Length == 4)
            {
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int verse = int.Parse(parts[2]);
                text = parts[3];
                reference = new Reference(book, chapter, verse);
            }
            else
            {
                Console.WriteLine("Invalid line format.");
                continue;
            }

            Scripture scripture = new Scripture(reference, text);

            // Single while loop that waits for user input
            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide more words, or type 'next' to go to the next scripture, or 'quit' to exit.");

                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    return;

                if (input.ToLower() == "next")
                    break;

                scripture.HideRandomWords(3);

                if (scripture.IsComplete())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine("\nAll words are hidden. Moving to next scripture...");
                    Console.ReadLine();
                    break;
                }
            }
        }

        Console.WriteLine("\nAll scriptures completed. Press Enter to exit.");
        Console.ReadLine();
    }
}
