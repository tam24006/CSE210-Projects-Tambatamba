
public class Activity
{
    private string _date;
    private double _length;
    private string _type;

    public Activity(string date, double duration, string type)
    {
        _date = date;
        _length = duration;
        _type = type;
    }

    public double GetLength()
    {
        return _length;
    }
    public virtual double GetDistance()
    {
        return 1;
    }
    public virtual double GetSpeed()
    {
        return 1;
    }
    public virtual double GetPace()
    {
        return 1;
    }
    public string GetSummary()
    {
        return $"{_date} {_type} ({_length} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}