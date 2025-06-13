using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    public List<Goal> Goals { get; set; } = new List<Goal>();
    public int TotalPoints { get; set; }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Goals[i].Name} ({Goals[i].Description})");
        }
    }

    public void RecordGoalEvent(int index)
    {
        if (index >= 0 && index < Goals.Count)
        {
            Goals[index].RecordEvent();
            TotalPoints += Goals[index].Points;

            if (Goals[index] is ChecklistGoal checklist && checklist.CurrentCount == checklist.TargetCount)
            {
                TotalPoints += checklist.BonusPoints;
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in Goals)
            {
                if (goal is SimpleGoal simple)
                {
                    writer.WriteLine($"SimpleGoal|{simple.Name}|{simple.Description}|{simple.Points}|{simple.Completed}");
                }
                else if (goal is EternalGoal eternal)
                {
                    writer.WriteLine($"EternalGoal|{eternal.Name}|{eternal.Description}|{eternal.Points}");
                }
                else if (goal is ChecklistGoal checklist)
                {
                    writer.WriteLine($"ChecklistGoal|{checklist.Name}|{checklist.Description}|{checklist.Points}|{checklist.CurrentCount}|{checklist.TargetCount}|{checklist.BonusPoints}");
                }
            }
        }

        Console.WriteLine("Goals saved!");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        Goals.Clear();

        foreach (string line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split('|');
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                var goal = new SimpleGoal
                {
                    Name = parts[1],
                    Description = parts[2],
                    Points = int.Parse(parts[3]),
                    Completed = bool.Parse(parts[4])
                };
                Goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                var goal = new EternalGoal
                {
                    Name = parts[1],
                    Description = parts[2],
                    Points = int.Parse(parts[3])
                };
                Goals.Add(goal);
            }
            else if (type == "ChecklistGoal")
            {
                var goal = new ChecklistGoal
                {
                    Name = parts[1],
                    Description = parts[2],
                    Points = int.Parse(parts[3]),
                    CurrentCount = int.Parse(parts[4]),
                    TargetCount = int.Parse(parts[5]),
                    BonusPoints = int.Parse(parts[6])
                };
                Goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded!");
    }
}
