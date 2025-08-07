using System;

public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _targetCount;
    private int _currentCount;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int currentCount = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = currentCount;
    }

    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _currentCount++;
        }
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetDetails()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {Name} ({Description}) -- Completed {_currentCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{_bonus}|{_targetCount}|{_currentCount}";
    }

    public override string GetSaveData()
    {
        // This method is required by the base class to save goal data to file
        return GetStringRepresentation();
    }

    public int GetBonusPoints()
    {
        return _bonus;
    }
}
