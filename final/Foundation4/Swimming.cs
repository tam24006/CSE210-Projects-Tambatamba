
public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, double duration, double laps) : base(date, duration, "Swimming")
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override double GetSpeed()
    {
        return GetDistance() / (GetLength() * 60);
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}