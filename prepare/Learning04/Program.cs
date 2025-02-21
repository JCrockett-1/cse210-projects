using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment homework = new Assignment("James Crockett", "Math");
        Console.WriteLine(homework.GetSummary());

        MathAssignment mathHomework = new MathAssignment("Santiago Crockett", "Division", "2.9", "20-21");
        Console.WriteLine(mathHomework.GetSummary());
        Console.WriteLine(mathHomework.getHomeworkList());


        WritingAssignment writingHomework = new WritingAssignment("Mary Crockett", "American History", "The Lone Star State");
        Console.WriteLine(writingHomework.GetSummary());
        Console.WriteLine(writingHomework.getWritingInformation());
    }
}