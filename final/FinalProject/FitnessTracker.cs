using System;
using System.Collections.Generic;

public class FitnessTracker
{
    private List<Exercise> exercises;

    public FitnessTracker()
    {
        exercises = new List<Exercise>();
    }

    public void AddExercise(Exercise exercise)
    {
        exercises.Add(exercise);
        Console.WriteLine($"Added {exercise.Name} to the fitness tracker.\n");
    }

    public void DisplayExercises()
    {
        Console.WriteLine("Fitness Tracker Exercises:");
        foreach (var exercise in exercises)
        {
            exercise.DisplayExerciseInfo();
            Console.WriteLine();
        }
    }

    public double CalculateTotalCaloriesBurned()
    {
        double totalCaloriesBurned = 0.0;
        foreach (var exercise in exercises)
        {
            totalCaloriesBurned += exercise.CalculateCaloriesBurned();
        }
        return totalCaloriesBurned;
    }
}
