using System;

class Program
{
    static void Main(string[] args)
    {
         Address address1 = new Address("123 Tech Street", "Silicon Valley", "CA", "USA");
        Lecture event1 = new Lecture("Tech Innovations 2025", "A lecture on the latest technology trends.", "2025-04-15", "10:00 AM", address1, "Dr. Jane Smith", 200);
        event1.DisplayFullMessage();
        Console.WriteLine();
        event1.DisplayShortMessage();
        Console.WriteLine();
        event1.DisplayStandardMessage();
        Console.WriteLine();

        Address address2 = new Address("456 Event Plaza", "New York", "NY", "USA");
        Reception event2 = new Reception("Business Networking Event", "An evening of networking with industry professionals.", "2025-05-10", "6:00 PM", address2, "rsvp@businessnetwork.com");
        event2.DisplayFullMessage();
        Console.WriteLine();
        event2.DisplayShortMessage();
        Console.WriteLine();
        event2.DisplayStandardMessage();
        Console.WriteLine();

        Address address3 = new Address("789 Park Lane", "Denver", "CO", "USA");
        OutdoorGathering event3 = new OutdoorGathering("Community Picnic", "A fun outdoor gathering for the community.", "2025-06-20", "12:00 PM", address3, "Sunny weather expected");
        event3.DisplayFullMessage();
        Console.WriteLine();
        event3.DisplayShortMessage();
        Console.WriteLine();
        event3.DisplayStandardMessage();


    }
}