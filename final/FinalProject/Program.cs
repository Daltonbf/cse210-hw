using System;
class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat("Whiskers", 3);
        Dog dog = new Dog("Buddy", 5);
        cat.Feed();
        cat.Play();
        cat.CheckHealth();
        dog.Feed();
        dog.Play();
        dog.CheckHealth();
    }
}
//I started by getting the basics for both a dog and a cat pet in this final project. I will have to continue to add more classes of animals and follow suit with their subclasses of being fed and playingwith them.
//This start has me excited to see where I can take this to. I hope I can solve issues I ay most likely run into along the way with how I can track all of this information and keep progress for what the user does.