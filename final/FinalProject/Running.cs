class Running : Exercise
{
    public override void start()
    {
        Console.WriteLine("Running started");
    }

    public override void pause()
    {
        Console.WriteLine("Running paused");
    }

    public override void stop()
    {
        Console.WriteLine("Running stopped");
    }
}
