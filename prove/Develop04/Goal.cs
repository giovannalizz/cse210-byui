using System;
using System.Collections.Generic;
using System.IO;

public class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    public virtual void RecordEvent() { }

    public virtual bool IsComplete()
    {
        return false;
    }
}

public class SimpleGoal : Goal
{
    public bool Completed { get; set; }

    public override void RecordEvent()
    {
        Completed = true;
        Console.WriteLine($"You earned {Points} points!");
    }

    public override bool IsComplete()
    {
        return Completed;
    }
}

public class EternalGoal : Goal
{
    public override void RecordEvent()
    {
        Console.WriteLine($"You earned {Points} points!");
    }

    public override bool IsComplete()
    {
        return false;
    }
}

public class ChecklistGoal : Goal
{
    public int CurrentCount { get; set; }
    public int TargetCount { get; set; }
    public int BonusPoints { get; set; }

    public override void RecordEvent()
    {
        CurrentCount++;
        Console.WriteLine($"You earned {Points} points!");

        if (CurrentCount == TargetCount)
        {
            Console.WriteLine($"Goal completed! Bonus: {BonusPoints} points!");
        }
        else
        {
            Console.WriteLine($"Progress: {CurrentCount}/{TargetCount} completions.");
        }
    }

    public override bool IsComplete()
    {
        return CurrentCount >= TargetCount;
    }
        
}