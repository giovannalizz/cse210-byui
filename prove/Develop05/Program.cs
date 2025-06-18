using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu: ");
            Console.WriteLine("1. Add New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddNewGoal(manager);
                    break;
                case "2":
                    manager.DisplayGoals();
                    break;
                case "3":
                    RecordGoalEvent(manager);
                    break;
                case "4":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile);
                    break;
                case "5":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    manager.LoadGoals(loadFile);
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid Option.");
                    break;

            }


        }

    }

    static void AddNewGoal(GoalManager manager)
    {
        Console.WriteLine("Choose goal type: ");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        string type = Console.ReadLine();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        if (type == "1")
        {
            goal = new SimpleGoal { Name = name, Description = desc, Points = points };
        }
        else if (type == "2")
        {
            goal = new EternalGoal { Name = name, Description = desc, Points = points };
        }
        else if (type == "3")
        {
            Console.Write("Enter target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            goal = new ChecklistGoal
            {
                Name = name,
                Description = desc,
                Points = points,
                TargetCount = target,
                BonusPoints = bonus
            };
        }

        if (goal != null)
        {
            manager.AddGoal(goal);
            Console.WriteLine("Goal added!");
        }
    }
    static void RecordGoalEvent(GoalManager manager)
    {
        manager.DisplayGoals();
        Console.Write("Enter the number of the goal to record: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        manager.RecordGoalEvent(index);
    }

}