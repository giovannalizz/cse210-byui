using System;
using System.Threading;

public class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void Run()
    {
        // Optionally leave this empty or add shared behavior
    }

    public void AskForDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");

        string input = Console.ReadLine();
        int duration;

        while (!int.TryParse(input, out duration) || duration <= 0)
        {
            Console.Write("Please enter a valid number greater than 0: ");
            input = Console.ReadLine();
        }
        Duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {Name} activity.\n");
        Console.WriteLine(Description);
        Console.WriteLine("\nGet ready...\n");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed another {Duration} seconds of the {Name} activity.");
        Console.WriteLine();
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
}
