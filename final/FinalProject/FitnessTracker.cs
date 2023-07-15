using System;
using System.Collections.Generic;

class FitnessTracker
{
    private User user;
    private List<Exercise> exercises;
    private List<Goal> goals;

    public void addUser(User user)
    {
        this.user = user;
    }

    public void addExercise(Exercise exercise)
    {
        if (exercises == null)
            exercises = new List<Exercise>();

        exercises.Add(exercise);
    }

    public void addGoal(Goal goal)
    {
        if (goals == null)
            goals = new List<Goal>();

        goals.Add(goal);
    }

    public void trackExercise(Exercise exercise)
    {
        // Perform tracking logic here
        Console.WriteLine("Tracking exercise: " + exercise.getName());
    }

    public List<Exercise> generateRecommendations()
    {
        // Generate exercise recommendations
        return new List<Exercise>();
    }

    public void displayProgress()
    {
        // Display progress logic here
        Console.WriteLine("Displaying progress");
    }
}
