using System;
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        SimpleGoal exerciseGoal = new SimpleGoal("Exercise", 100);
        ChecklistGoal meditationGoal = new ChecklistGoal("Meditation", 10, 500);
        EternalGoal scriptureReadingGoal = new EternalGoal("Scripture Reading", 100);
        goalManager.AddGoal(exerciseGoal);
        goalManager.AddGoal(meditationGoal);
        goalManager.AddGoal(scriptureReadingGoal);
        goalManager.RecordEvent("Exercise");
        goalManager.RecordEvent("Meditation");
        goalManager.RecordEvent("Meditation");
        goalManager.RecordEvent("Scripture Reading");
        goalManager.RecordEvent("Scripture Reading");
        goalManager.ShowGoals();
        goalManager.ShowTotalPoints();
    }
}
