using System;
public class Bird : Pet
{
    public Bird(string name, int age) : base(name, age) { }
    public override void Feed()
    {
        Console.WriteLine($"{name} the bird is eating seeds.");
        hungerLevel -= 5;
        if (hungerLevel < 0) hungerLevel = 0;
    }
    public override void Play()
    {
        Console.WriteLine($"{name} the bird is chirping happily.");
        happinessLevel += 5;
        if (happinessLevel > 100) happinessLevel = 100;
    }
}
