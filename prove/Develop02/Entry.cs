using System;
using System.Collections.Generic;

public class Entry
{
    // Fields to store the date, prompt, and response
    public string date;
    public string prompt;
    public string response;

    // Set the current date
    public void GenerateDate()
    {
        DateTime currentTime = DateTime.Now;
        date = currentTime.ToShortDateString();
    }

    // Choose a random prompt and display it
    public void GeneratePrompt()
    {
        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random rand = new Random();
        int index = rand.Next(prompts.Count);

        prompt = prompts[index];
        Console.WriteLine(prompt);
    }

    // Get user response from the console
    public void GetResponse()
    {
        Console.Write("> ");
        response = Console.ReadLine();
    }

    // Display the full journal entry
    public void ShowEntry()
    {
        Console.WriteLine($"Date: {date}");
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine($"Response: {response}");
    }
}
