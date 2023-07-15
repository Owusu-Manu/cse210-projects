using System;

public class Goal
{
    public string Description { get; set; }
    public DateTime Deadline { get; set; }

    public void DisplayGoalInfo()
    {
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Deadline: {Deadline.ToShortDateString()}");
        Console.WriteLine();
    }
}
