using System;

public class Running : Exercise
{
    public double Distance { get; set; }

    public override void DisplayExerciseInfo()
    {
        Console.WriteLine($"Exercise: {Name}");
        Console.WriteLine($"Duration: {Duration.TotalMinutes} minutes");
        Console.WriteLine($"Intensity: {Intensity}");
        Console.WriteLine($"Distance: {Distance} km");
    }

    public override double CalculateCaloriesBurned()
    {
        double caloriesPerMinute = 10.0 + (Intensity * 2.0);
        double totalCaloriesBurned = caloriesPerMinute * Duration.TotalMinutes;
        return totalCaloriesBurned;
    }
}
