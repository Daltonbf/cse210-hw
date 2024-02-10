abstract class Goal
{
    public string Name { get; set; }
    public bool IsCompleted { get; protected set; }

    public Goal(string name)
    {
        Name = name;
        IsCompleted = false;
    }
    public abstract int CalculatePoints();
    public abstract string GetProgress();
    public virtual void MarkAsCompleted()
    {
        IsCompleted = true;
    }
}
