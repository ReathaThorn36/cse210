public class Cycling : Exercise
{
    private double _speed; // in kph

    public Cycling(string date, int duration, double speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance() => _speed * _duration / 60;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;
}
