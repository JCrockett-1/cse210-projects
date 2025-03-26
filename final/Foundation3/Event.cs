public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _eventType;

    public Event(string title, string description, string date, string time, string address, string eventType)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    public void DisplayStandardMessage()
    {
        Console.WriteLine($"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}");
    }

    public void DisplayShortMessage()
    {
        Console.WriteLine($"Event Type: {_eventType}\nTitle: {_title}\nDate: {_date}");    
    }
}