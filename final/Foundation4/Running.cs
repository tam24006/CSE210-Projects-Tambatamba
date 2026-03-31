
public class Running : Activity
{
    private double _distance;

    public Running(string date, double duration, double distance) : base(date, duration, "Running")
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return GetDistance() / (GetLength() * 60);
    }
    public override double GetPace()
    {
        return GetLength() / _distance;
    }
}