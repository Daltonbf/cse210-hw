using System;
public class Dog : Pet
{
    public Dog(string name, int age) : base(name, age) { }
    public override void Feed()
    {
        Console.WriteLine($"{name} the dog is eating bones.");
        hungerLevel -= 15;
        if (hungerLevel < 0) hungerLevel = 0;
    }
    public override void Play()
    {
        Console.WriteLine($"{name} the dog is fetching a ball.");
        happinessLevel += 15;
        if (happinessLevel > 100) happinessLevel = 100;
    }
}
