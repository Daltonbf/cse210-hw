using System;
using System.Collections.Generic;
class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalPoints = 0;
    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }
    public void RecordEvent(string goalName)
    {
        Goal goal = goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.MarkAsCompleted();
            totalPoints += goal.CalculatePoints();
            Console.WriteLine($"Event recorded for goal '{goalName}'. You earned {goal.CalculatePoints()} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{goalName}' not found.");
        }
    }
    public void ShowGoals()
    {
        Console.WriteLine("Your Goals:");
        foreach (Goal goal in goals)
        {
            string progress = goal.GetProgress();
            Console.WriteLine($"{progress} {goal.Name}");
        }
    }
    public void ShowTotalPoints()
    {
        Console.WriteLine($"Total Points: {totalPoints}");
    }
}
