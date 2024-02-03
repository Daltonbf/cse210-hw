using System;
class ReflectionActivity : Activity
{
    public ReflectionActivity() : base() { }
    public void StartReflectionActivity()
    {
        string[] reflectionPrompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        Random random = new Random();
        string selectedPrompt = reflectionPrompts[random.Next(reflectionPrompts.Length)];
        StartActivity("Reflection Activity", selectedPrompt);
        string[] reflectionQuestions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        foreach (var question in reflectionQuestions)
        {
            Console.WriteLine(question);
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Spinner animation or any animation here...");
        }

        EndActivity("Reflection Activity");
    }
}
