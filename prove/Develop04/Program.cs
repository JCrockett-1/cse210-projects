// I exceeded requirements by adding code in the reflection and listing activity classes so that the all the prompts and questions will be all cycled through before they use one twice.

using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity one = new BreathingActivity();
        ReflectionActivity two = new ReflectionActivity();
        ListingActivity three = new ListingActivity();

        bool Continue = true;
        while (Continue == true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                one.StartActivty();
                one.BreatheCycle();
                one.FinishActivty();
            }

            if (choice == "2")
            {
                two.StartActivty();
                two.DisplayPrompt();
                two.AskRandomQuestion();
                two.FinishActivty();
            }

            if (choice == "3")
            {
                three.StartActivty();
                three.CollectResponses();
                three.DisplayResponsesCount();
                three.FinishActivty();
            }

            if (choice == "4")
            {
                Continue = false;
            }
        }
    }
}