using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("Goals file not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split('|');
            if (parts.Length == 0) continue;

            string goalType = parts[0];
            switch (goalType)
            {
                case "SimpleGoal":
                    if (parts.Length < 4) continue;
                    string name = parts[1] ?? "Unknown";
                    string description = parts[2] ?? "";
                    if (!int.TryParse(parts[3], out int points)) points = 0;
                    bool isComplete = parts.Length > 4 && bool.TryParse(parts[4], out bool complete) && complete;
                    _goals.Add(new SimpleGoal(name, description, points, isComplete));
                    break;

                case "EternalGoal":
                    if (parts.Length < 4) continue;
                    name = parts[1] ?? "Unknown";
                    description = parts[2] ?? "";
                    if (!int.TryParse(parts[3], out points)) points = 0;
                    _goals.Add(new EternalGoal(name, description, points));
                    break;

                case "ChecklistGoal":
                    if (parts.Length < 7) continue;
                    name = parts[1] ?? "Unknown";
                    description = parts[2] ?? "";
                    if (!int.TryParse(parts[3], out points)) points = 0;
                    if (!int.TryParse(parts[4], out int targetCount)) targetCount = 0;
                    if (!int.TryParse(parts[5], out int bonus)) bonus = 0;
                    if (!int.TryParse(parts[6], out int currentCount)) currentCount = 0;
                    _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonus, currentCount));
                    break;

                default:
                    Console.WriteLine($"Unknown goal type: {goalType}");
                    break;
            }
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetSaveData());
            }
        }
    }

    public void AddGoal()
    {
        Console.WriteLine("Choose goal type: (1) SimpleGoal, (2) EternalGoal, (3) ChecklistGoal");
        string? choiceInput = Console.ReadLine();
        int choice;
        if (!int.TryParse(choiceInput, out choice))
        {
            Console.WriteLine("Invalid input, returning to menu.");
            return;
        }

        Console.Write("Enter name: ");
        string? name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name)) name = "Default Name";

        Console.Write("Enter description: ");
        string? description = Console.ReadLine();
        if (description == null) description = "";

        Console.Write("Enter points: ");
        string? pointsInput = Console.ReadLine();
        int points;
        if (!int.TryParse(pointsInput, out points)) points = 0;

        switch (choice)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("Enter target count: ");
                string? targetInput = Console.ReadLine();
                int targetCount;
                if (!int.TryParse(targetInput, out targetCount)) targetCount = 0;

                Console.Write("Enter bonus points: ");
                string? bonusInput = Console.ReadLine();
                int bonus;
                if (!int.TryParse(bonusInput, out bonus)) bonus = 0;

                _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    // Other methods such as DisplayGoals(), RecordEvent(), etc. can be implemented similarly with null-safe input handling.
}
