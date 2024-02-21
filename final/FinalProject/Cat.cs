using System;
public class Cat : Pet
{
    public Cat(string name, int age) : base(name, age) { }
    public override void Feed()
    {
        Console.WriteLine($"{name} the cat is eating fish.");
        hungerLevel -= 10;
        if (hungerLevel < 0) hungerLevel = 0;
    }
    public override void Play()
    {
        Console.WriteLine($"{name} the cat is playing with a toy mouse.");
        happinessLevel += 10;
        if (happinessLevel > 100) happinessLevel = 100;
    }
}
