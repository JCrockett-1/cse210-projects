public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string eventType, string speaker, int capacity) : base(title, description, date, time, address, eventType)
    {
        _speaker = speaker;
        _capacity = capacity;
        _eventType = "Lecture";
    }

    public void DisplayFullMessage()
    {
        Console.WriteLine($"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.CompleteAddress()}\nEvent Type: {_eventType}\nSpeaker: {_speaker}\nCapacity: {_capacity}");
    }
}