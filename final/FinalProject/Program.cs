using System;

class Program
{
    static void Main()
    {
        FitnessTracker fitnessTracker = new FitnessTracker();

        fitnessTracker.AddExercise(new Running
        {
            Name = "Morning Run",
            Duration = TimeSpan.FromMinutes(30),
            Intensity = 5,
            Distance = 5.0
        });

        fitnessTracker.AddExercise(new Weightlifting
        {
            Name = "Strength Training",
            Duration = TimeSpan.FromMinutes(45),
            Intensity = 8,
            Sets = 3,
            Reps = 10
        });

        fitnessTracker.AddExercise(new Yoga
        {
            Name = "Evening Yoga",
            Duration = TimeSpan.FromMinutes(60),
            Intensity = 3,
            Pose = "Warrior II"
        });

        fitnessTracker.DisplayExercises();

        double totalCaloriesBurned = fitnessTracker.CalculateTotalCaloriesBurned();
        Console.WriteLine($"Total Calories Burned: {totalCaloriesBurned} calories");

        Console.ReadLine();
    }
}
