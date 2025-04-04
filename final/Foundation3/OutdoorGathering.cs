public class OutdoorGathering : Event
{
    private string _weatherStatement;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherStatement) : base(title, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
        _eventType = "Outdoor Gathering";   
    }

    public override string GetFullMessage()
    {
        return ($"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.CompleteAddress()}\nEvent Type: {_eventType}\nWeather Statement: {_weatherStatement}");
    }
}