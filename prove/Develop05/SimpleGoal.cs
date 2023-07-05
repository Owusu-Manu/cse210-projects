class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points)
    {
    }

    public override void DisplayGoal()
    {
        Console.WriteLine("Simple Goal: " + GetName());
    }

    public override void StartActivity()
    {
        Console.WriteLine("Starting simple goal activity");
    }

    public override void EndActivity()
    {
        Console.WriteLine("Ending simple goal activity");
    }
}
