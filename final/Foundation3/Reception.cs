
public class Reception : Event
{
    private string _emailRSVP;

    public Reception(string title, string description, string date, Address address, string time, string eventType, string emailRSVP)
        : base(title, description, date, address, time, eventType)
    {
        _emailRSVP = emailRSVP;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nRSVP Email: {_emailRSVP}";
    }
}