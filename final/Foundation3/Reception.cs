using System.ComponentModel.DataAnnotations;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, string address, string eventType, string rsvpEmail) : base(title, description, date, time, address, eventType)
    {
        _rsvpEmail = rsvpEmail;
    }

    public void DisplayFullMessage()
    {
        Console.WriteLine($"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nEvent Type: {_eventType}\nrsvpEmail: {_rsvpEmail}");
    } 
}