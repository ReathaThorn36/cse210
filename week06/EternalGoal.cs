public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name ?? string.Empty, description ?? string.Empty, points)
    {
    }

    public override void RecordEvent()
    {
        // Eternal goals never complete
    }

    public override bool IsComplete()
    {
        return false; // Never complete
    }

    public override string GetDetails()
    {
        return $"[ ] {Name} ({Description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }

    public override string GetSaveData()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }
}
