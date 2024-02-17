using System;
public class Cat : Pet
{
    public Cat(string name, int age) : base(name, age)
    {
    }

    public override void Feed()
    {
        Console.WriteLine($"{Name} the cat is eating fish.");
    }
    public override void Play()
    {
        Console.WriteLine($"{Name} the cat is playing with a toy mouse.");
    }
}
