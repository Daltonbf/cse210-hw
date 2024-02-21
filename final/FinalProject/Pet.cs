using System;
public abstract class Pet
{
    protected string name;
    protected int age;
    protected int hungerLevel;
    protected int happinessLevel;
    public Pet(string name, int age)
    {
        this.name = name;
        this.age = age;
        this.hungerLevel = 50;
        this.happinessLevel = 50;
    }
    public abstract void Feed();
    public abstract void Play();
    public void CheckHealth()
    {
        Console.WriteLine($"{name}'s health status:");
        Console.WriteLine($"Hunger level: {hungerLevel}");
        Console.WriteLine($"Happiness level: {happinessLevel}");
    }
    public string GetName()
    {
        return name;
    }
}
