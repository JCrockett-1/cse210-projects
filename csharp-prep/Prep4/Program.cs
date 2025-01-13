using System;
using System.Collections.Generic;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        bool isZero = true;

        do
        {
            Console.Write("Enter number: ");
            int numberEntered = int.Parse(Console.ReadLine());
            isZero = true;

            if (numberEntered != 0)
            {
                numbers.Add(numberEntered);
                isZero = false;
            }
        } while (isZero == false);

        int sumOfList = 0;
        foreach (int number in numbers)
        {
            sumOfList += number;
        }
        Console.WriteLine($"The sum is: {sumOfList}");

        float avgOfList = (float)sumOfList / numbers.Count;
        Console.WriteLine($"The average is: {avgOfList}");

        int largestNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");









    }
}