using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);

        bool hasGuessed = false;
        do
        {
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            if (guess > randomNumber)
            {
                Console.WriteLine("Lower");
                hasGuessed = false;
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("Higher");
                hasGuessed = false;
            }
            if (guess == randomNumber)
            {
                Console.WriteLine("You guessed it!");
                hasGuessed = true;
            }
        } while (hasGuessed == false);




    }
}