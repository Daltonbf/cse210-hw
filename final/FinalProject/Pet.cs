using System;
public abstract class Pet
{
    private string name;
    private int age;
    private int hungerLevel;
    private int happinessLevel;\
    public Pet(string name, int age)
    {
        this.name = name;
        this.age = age;
        this.hungerLevel = 50;
        this.happinessLevel = 50;
    }
    public string Name { get { return name; } }
    public int Age { get { return age; } }
    public abstract void Feed();
    public abstract void Play();
    public void CheckHealth()
    {
        Console.WriteLine($"{name}'s health status:");
        Console.WriteLine($"Hunger level: {hungerLevel}");
        Console.WriteLine($"Happiness level: {happinessLevel}");
    }
}
