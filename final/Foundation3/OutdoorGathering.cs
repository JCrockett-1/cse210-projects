public class OutdoorGathering : Event
{
    private string _weatherStatement;

    public OutdoorGathering(string title, string description, string date, string time, string address, string eventType, string weatherStatement) : base(title, description, date, time, address, eventType)
    {
        _weatherStatement = weatherStatement;
    }

    public void DisplayFullMessage()
    {
        Console.WriteLine($"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nEvent Type: {_eventType}\nWeather Statement: {_weatherStatement}");
    }
}