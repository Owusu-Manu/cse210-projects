using System;
using System.Collections.Generic;
using System.Threading;

public class Mindfulness
{
    private string programTitle;
    private string userInput;

    public Mindfulness(string title)
    {
        programTitle = title;
    }

    public void StartProgram()
    {
        Console.WriteLine(programTitle);
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");
            userInput = Console.ReadLine();
            ProcessUserInput();
        }
    }

    private void ProcessUserInput()
    {
        switch (userInput)
        {
            case "1":
                BreathingActivity breathingActivity = new BreathingActivity();
                PerformActivity(breathingActivity);
                break;

            case "2":
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                PerformActivity(reflectionActivity);
                break;

            case "3":
                ListingActivity listingActivity = new ListingActivity();
                PerformActivity(listingActivity);
                break;

            case "4":
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    private void DisplayOutput(string message)
    {
        Console.WriteLine(message);
    }

    private void PerformActivity(Activity activity)
    {
        activity.Start();
        activity.End();
    }
}
