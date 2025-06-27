using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List as many things as you can that make you happy.",
        "List people you love.",
        "List places that bring you peace.",
        "List things you are grateful for."
    };

    public ListingActivity()
        : base("Listing", "This activity helps you focus by having you list positive things.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        AskForDuration();

        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        string prompt = _prompts[index];

        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("Start listing items. Press Enter after each one:");
        Console.WriteLine($"You have {Duration} seconds. Go!\n");

        List<string> userItems = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                userItems.Add(item);
            }
        }

        Console.WriteLine($"\nYou listed {userItems.Count} items.");
        DisplayEndingMessage();
    }
}
