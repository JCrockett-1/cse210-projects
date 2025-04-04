public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _eventType = "Lecture";
    }

    public override string GetFullMessage()
    {
        return ($"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.CompleteAddress()}\nEvent Type: {_eventType}\nSpeaker: {_speaker}\nCapacity: {_capacity}");
    }
}