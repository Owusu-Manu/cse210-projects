using System;

abstract class Goal
{
    private string _name;
    private int _points;
    private bool _completed;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _completed = false;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }

    public bool IsComplete()
    {
        return _completed;
    }

    public void CompleteGoal()
    {
        _completed = true;
    }

    public abstract void DisplayGoal();

    public abstract void StartActivity();

    public abstract void EndActivity();
}
