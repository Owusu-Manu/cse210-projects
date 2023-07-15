using System;

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }

    public void DisplayUserInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Height: {Height} cm");
        Console.WriteLine($"Weight: {Weight} kg");
        Console.WriteLine();
    }
}
