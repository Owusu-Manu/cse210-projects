class User
{
    private string name;
    private int age;
    private double weight;
    private double height;

    public void setName(string name)
    {
        this.name = name;
    }

    public void setAge(int age)
    {
        this.age = age;
    }

    public void setWeight(double weight)
    {
        this.weight = weight;
    }

    public void setHeight(double height)
    {
        this.height = height;
    }

    public double calculateBMI()
    {
        // Calculate BMI logic here
        return weight / (height * height);
    }
}
