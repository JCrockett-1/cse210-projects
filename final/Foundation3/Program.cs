using System;

class Program
{
    static void Main(string[] args)
    {
        List <Event> events = new List <Event>();

        Address address1 = new Address("35 Waying Street","San Francisco","California","USA");
        Lecture event1 = new Lecture("The Dark Arts","A lecture on the Dark Arts","4/23/2025","7:00 AM",address1,"Voldemort",25);
        events.Add(event1);

        Address address2 = new Address("100 Ugly Road","Phoenix","Arizona","USA");
        OutdoorGathering event2 = new OutdoorGathering("Gardening Gathering","Come outside and learn to Garden!","4/12/2025","9:00 AM",address2,"It will be hot and sunny, perfect for gardening!");
        events.Add(event2);

        Address address3 = new Address("20 Weird Street","Berlin","Berlin","Germany");
        Reception event3 = new Reception("John and Mary's Wedding","This is the reception following John and Mary's temple sealing.","4/30/2025","4:00 PM", address3,"john46@email.com");
        events.Add(event3);

        foreach (Event eventPlanned in events)
        {
            Console.WriteLine("-Standard Message-");
            Console.WriteLine(eventPlanned.GetStandardMessage());
            Console.WriteLine();

            Console.WriteLine("-Short Message-");
            Console.WriteLine(eventPlanned.GetShortMessage());
            Console.WriteLine();

            Console.WriteLine("-Full Message-");
            Console.WriteLine(eventPlanned.GetFullMessage()); 
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}