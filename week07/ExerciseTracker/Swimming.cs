public class Swimming : Exercise
{
    private int _laps;

    public Swimming(string date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * 50.0 / 1000; // 50m pool, convert to km

    public override double GetSpeed() => GetDistance() / _duration * 60;

    public override double GetPace() => _duration / GetDistance();
}
