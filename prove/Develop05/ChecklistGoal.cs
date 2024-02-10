class ChecklistGoal : Goal
{
    public int TotalTimes { get; private set; }
    public int TimesCompleted { get; private set; }
    public int BonusPoints { get; private set; }
    public ChecklistGoal(string name, int totalTimes, int bonusPoints) : base(name)
    {
        TotalTimes = totalTimes;
        BonusPoints = bonusPoints;
    }
    public override void MarkAsCompleted()
    {
        TimesCompleted++;
        if (TimesCompleted >= TotalTimes)
        {
            IsCompleted = true;
        }
    }
    public override int CalculatePoints()
    {
        int points = TimesCompleted * 50;
        if (IsCompleted)
        {
            points += BonusPoints;
        }
        return points;
    }
    public override string GetProgress()
    {
        return $"Completed {TimesCompleted}/{TotalTimes} times";
    }
}
