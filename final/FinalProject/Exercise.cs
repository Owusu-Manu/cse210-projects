abstract class Exercise
{
    private string name;
    private int duration;
    private string intensity;

    public string getName()
    {
        return name;
    }

    public int getDuration()
    {
        return duration;
    }

    public string getIntensity()
    {
        return intensity;
    }

    public virtual void start()
    {
        Console.WriteLine("Exercise started");
    }

    public virtual void pause()
    {
        Console.WriteLine("Exercise paused");
    }

    public virtual void stop()
    {
        Console.WriteLine("Exercise stopped");
    }
}
