public abstract class Goal
{
    public string Name { get; }
    public string Description { get; }
    public int Points { get; }

    protected Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetails();
    public abstract string GetStringRepresentation();
    public abstract string GetSaveData();
}
