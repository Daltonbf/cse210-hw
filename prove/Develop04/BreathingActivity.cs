using System;
class BreathingActivity : Activity
{
    public BreathingActivity() : base() { }

    public void StartBreathingActivity()
    {
        StartActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Breathe out...");
            System.Threading.Thread.Sleep(1000);
        }
        EndActivity("Breathing Activity");
    }
}
