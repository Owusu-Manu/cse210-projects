using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create instances and use the FitnessTracker class
        FitnessTracker tracker = new FitnessTracker();
        User user = new User();
        user.setName("John Doe");
        tracker.addUser(user);

        Exercise running = new Running();
        Exercise weightlifting = new Weightlifting();
        Exercise yoga = new Yoga();
        tracker.addExercise(running);
        tracker.addExercise(weightlifting);
        tracker.addExercise(yoga);

        Goal goal = new Goal();
        goal.setTarget("Weight Loss");
        goal.setDuration(30);
        tracker.addGoal(goal);

        tracker.trackExercise(running);

        List<Exercise> recommendations = tracker.generateRecommendations();

        tracker.displayProgress();
    }
}
