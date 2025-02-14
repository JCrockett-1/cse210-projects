using System;

class Program
{
    static void Main(string[] args)
    {
        Reference myReference = new Reference("1 Nephi",2,2);
        Scripture myScripture = new Scripture("And it came to pass that the Lord commanded my father, even in a dream, that he should take his family and depart into the wilderness.");

        bool wordsLeft = true;

        while (wordsLeft == true)
        {
            Console.Clear();
            myReference.Display();
            myScripture.Display();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input == "")
            {
                myScripture.RemoveWord();
            }
            else if (input == "quit")
            {
                wordsLeft = false;
            }

            if ()
        }
    }
}