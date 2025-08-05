using System;

public abstract class Exercise
{
    protected string _date;
    protected int _duration; // in minutes

    public Exercise(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract double GetDistance(); // in km
    public abstract double GetSpeed();    // in kph
    public abstract double GetPace();     // in min per km

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_duration} min): " +
               $"Distance: {GetDistance():0.0} km, " +
               $"Speed: {GetSpeed():0.0} kph, " +
               $"Pace: {GetPace():0.0} min per km";
    }
}
