
public class Outdoor : Event
{
    private string _weatherForecast;

    public Outdoor(string title, string description, string date, Address address, string time, string eventType, string weatherForecast)
        : base(title, description, date, address, time, eventType)
    {
        _weatherForecast = weatherForecast;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nWeather Forecast: {_weatherForecast}";
    }
}