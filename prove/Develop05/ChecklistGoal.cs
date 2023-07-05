class ChecklistGoal : Goal
{
    private int _requiredCount;
    private int _currentCount;

    public ChecklistGoal(string name, int points, int requiredCount) : base(name, points)
    {
        _requiredCount = requiredCount;
        _currentCount = 0;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine("Checklist Goal: " + GetName() + " (" + _currentCount + "/" + _requiredCount + ")");
    }

    public override void StartActivity()
    {
        Console.WriteLine("Starting checklist goal activity");
    }

    public override void EndActivity()
    {
        Console.WriteLine("Ending checklist goal activity");
    }

    public void RecordGoal()
    {
        _currentCount++;
        if (_currentCount == _requiredCount)
        {
            CompleteGoal();
        }
    }
}
