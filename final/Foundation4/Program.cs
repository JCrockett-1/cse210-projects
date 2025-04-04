using System;

class Program
{
    static void Main(string[] args)
    {
        List <Activity> activities = new List <Activity>();
        activities.Add(new Running("4/03/2025",60,5));
        activities.Add(new Cycling("4/04/2025",10,20));
        activities.Add(new Swimming("4/05/2025",10,6));

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}