using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you did something truly selfless.",
        "Recall a moment when you felt deeply at peace.",
        "What are you most grateful for today?",
        "Think of someone who inspires you."
    };

    public ReflectionActivity()
        : base("Reflection", "This activity helps you reflect on times in your life when you've shown strength and resilience.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        AskForDuration();

        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        string prompt = _prompts[index];

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"> {prompt}\n");

        Console.WriteLine("Reflecting...");
        ShowCountdown(Duration);  // or ShowSpinner(Duration) if you implement it

        DisplayEndingMessage();
    }
}
