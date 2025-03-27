using System;

class Program
{
    static void Main(string[] args)
    {
        Running activity1 = new Running("2021-01-01", 10, 5);
        activity1.GetSummary();
        Console.WriteLine();

        Cycling activity2 = new Cycling("2021-01-02", 20, 30);
        activity2.GetSummary();
        Console.WriteLine();

        Swimming activity3 = new Swimming("2021-01-03", 30, 10);
        activity3.GetSummary();
    }
}