using System;

public abstract class Exercise
{
    public string Name { get; set; }
    public TimeSpan Duration { get; set; }
    public int Intensity { get; set; }

    public abstract void DisplayExerciseInfo();
    public abstract double CalculateCaloriesBurned();
}
