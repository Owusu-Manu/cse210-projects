class Yoga : Exercise
{
    public override void start()
    {
        Console.WriteLine("Yoga started");
    }

    public override void pause()
    {
        Console.WriteLine("Yoga paused");
    }

    public override void stop()
    {
        Console.WriteLine("Yoga stopped");
    }
}
