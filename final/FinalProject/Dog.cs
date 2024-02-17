using System;
public class Dog : Pet
{
    public Dog(string name, int age) : base(name, age)
    {
    }

    public override void Feed()
    {
        Console.WriteLine($"{Name} the dog is eating bones.");
    }
    public override void Play()
    {
        Console.WriteLine($"{Name} the dog is fetching a ball.");
    }
}
