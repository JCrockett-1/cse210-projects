public abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _eventType;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardMessage()
    {
        return ($"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.CompleteAddress()}");
    }

    public string GetShortMessage()
    {
        return ($"Event Type: {_eventType}\nTitle: {_title}\nDate: {_date}");    
    }

    public abstract string GetFullMessage();
}