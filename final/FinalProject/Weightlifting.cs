using System;

public class Weightlifting : Exercise
{
    public int Sets { get; set; }
    public int Reps { get; set; }

    public override void DisplayExerciseInfo()
    {
        Console.WriteLine($"Exercise: {Name}");
        Console.WriteLine($"Duration: {Duration.TotalMinutes} minutes");
        Console.WriteLine($"Intensity: {Intensity}");
        Console.WriteLine($"Sets: {Sets}");
        Console.WriteLine($"Reps: {Reps}");
    }

    public override double CalculateCaloriesBurned()
    {
        double caloriesPerMinute = 8.0 + (Intensity * 1.5);
        double totalCaloriesBurned = caloriesPerMinute * Duration.TotalMinutes;
        return totalCaloriesBurned;
    }
}
