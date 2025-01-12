using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage grade (without the % symbol)? ");
        int grade = int.Parse(Console.ReadLine());
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your letter grade is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats! You passed the course!");
        }
        else
        {
            Console.WriteLine("You didn't pass the course, keep working at it, and you'll do better next time!");
        }
    }
}