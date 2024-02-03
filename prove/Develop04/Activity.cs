using System;
class Activity
{
    protected int duration;
    public Activity()
    {
        Console.WriteLine("Welcome to the activity!");
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
    }
    protected void StartActivity(string activityName, string description)
    {
        Console.WriteLine($"{activityName} - {description}");
        Console.WriteLine("Prepare to begin...");
        System.Threading.Thread.Sleep(3000);
    }
    protected void EndActivity(string activityName)
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed {activityName} for {duration} seconds.");
        System.Threading.Thread.Sleep(3000);
    }
}
