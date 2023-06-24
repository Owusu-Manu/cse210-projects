using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points)
    {
    }

    public override void DisplayGoal()
    {
        Console.WriteLine("Eternal Goal: " + GetName());
    }

    public override void StartActivity()
    {
        Console.WriteLine("Starting eternal goal activity");
    }

    public override void EndActivity()
    {
        Console.WriteLine("Ending eternal goal activity");
    }
}
