using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Pet> pets = new List<Pet>();
        pets.Add(new Cat("Whiskers", 3));
        pets.Add(new Dog("Buddy", 5));
        pets.Add(new Bird("Polly", 2));
        foreach (var pet in pets)
        {
            Console.WriteLine($"Feeding {pet.GetName()}...");
            pet.Feed();
            Console.WriteLine();
            Console.WriteLine($"Playing with {pet.GetName()}...");
            pet.Play();
            Console.WriteLine();
            Console.WriteLine($"Checking {pet.GetName()}'s health...");
            pet.CheckHealth();
            Console.WriteLine();
        }
    }
}
