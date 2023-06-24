using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        User user = new User("John");
        List<UserGoal> userGoals = new List<UserGoal>();

        Goal goal1 = new SimpleGoal("Complete Task 1", 10);
        Goal goal2 = new EternalGoal("Attend Meeting", 5);
        Goal goal3 = new ChecklistGoal("Read Books", 20, 3);

        userGoals.Add(new UserGoal(user, goal1));
        userGoals.Add(new UserGoal(user, goal2));
        userGoals.Add(new UserGoal(user, goal3));

        Console.WriteLine("User: " + user.GetUsername());
        Console.WriteLine("Score: " + user.GetScore());

        foreach (UserGoal userGoal in userGoals)
        {
            Goal goal = userGoal.GetGoal();

            goal.DisplayGoal();
            goal.StartActivity();

            // Simulating goal completion
            goal.CompleteGoal();
            user.UpdateScore(goal.GetPoints());

            goal.EndActivity();

            Console.WriteLine("Score: " + user.GetScore());
        }
    }
}
