
public class Event
{ 
    private string _title;
    private string _description;
    private string _date;
    private Address _address;
    private string _time;
    private string _eventType;

    public Event(string title, string description, string date, Address address, string time, string eventType)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    public string StandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetFullAddress()}";
    }
    public string ShortDescription()
    {
        return $"Event Type: {_eventType}\nTitle: {_title}\nDate: {_date}";
    }
    public virtual string FullDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetFullAddress()}\nEvent Type: {_eventType}";
    }

       
}