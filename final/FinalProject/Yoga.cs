using System;

public class Yoga : Exercise
{
    public string Pose { get; set; }

    public override void DisplayExerciseInfo()
    {
        Console.WriteLine($"Exercise: {Name}");
        Console.WriteLine($"Duration: {Duration.TotalMinutes} minutes");
        Console.WriteLine($"Intensity: {Intensity}");
        Console.WriteLine($"Pose: {Pose}");
    }

    public override double CalculateCaloriesBurned()
    {
        double caloriesPerMinute = 5.0 + (Intensity * 1.0);
        double totalCaloriesBurned = caloriesPerMinute * Duration.TotalMinutes;
        return totalCaloriesBurned;
    }
}
