class Weightlifting : Exercise
{
    public override void start()
    {
        Console.WriteLine("Weightlifting started");
    }

    public override void pause()
    {
        Console.WriteLine("Weightlifting paused");
    }

    public override void stop()
    {
        Console.WriteLine("Weightlifting stopped");
    }
}
