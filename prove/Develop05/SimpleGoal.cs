class SimpleGoal : Goal
{
    public int Points { get; set; }
    public SimpleGoal(string name, int points) : base(name)
    {
        Points = points;
    }
    public override int CalculatePoints()
    {
        return IsCompleted ? Points : 0;
    }
    public override string GetProgress()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }
}
