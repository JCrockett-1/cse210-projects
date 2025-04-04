using System.ComponentModel.DataAnnotations;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
        _eventType = "Reception";
    }

    public override string GetFullMessage()
    {
        return ($"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.CompleteAddress()}\nEvent Type: {_eventType}\nrsvpEmail: {_rsvpEmail}");
    } 
}