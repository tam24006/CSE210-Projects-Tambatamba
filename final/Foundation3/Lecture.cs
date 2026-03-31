
public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, Address address, string time, string eventType, string speaker, int capacity)
        : base(title, description, date, address, time, eventType)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}