using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Start()
    {
        Console.WriteLine("Breathing Activity");
        Console.WriteLine(Description);
        Console.Write("Enter duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);
        Console.WriteLine("Start breathing...");
        Thread.Sleep(2000);
    }

    public override void End()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        Thread.Sleep(3000);
    }
}
