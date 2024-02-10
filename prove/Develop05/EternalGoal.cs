class EternalGoal : Goal
{
    public int PointsPerCompletion { get; private set; }
    public EternalGoal(string name, int pointsPerCompletion) : base(name)
    {
        PointsPerCompletion = pointsPerCompletion;
    }
    public override int CalculatePoints()
    {
        return PointsPerCompletion;
    }
    public override string GetProgress()
    {
        return "Eternal Goal";
    }
}
