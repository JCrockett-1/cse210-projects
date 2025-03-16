using System;
// I exceeded requirements by adding a random encouraging message after a goal is completed! The message isn't displayed however if the user attempts to record the event with the goal already having been completed.
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Manager manager = new Manager();
        bool Continue = true;
        while (Continue == true)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {manager.GetScore()} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                manager.AddGoal();
            }

            if (choice == "2")
            {
                manager.DisplayGoal();
            }

            if (choice == "3")
            {
                manager.Save();
            }

            if (choice == "4")
            {
                manager.Load();
            }

            if (choice == "5")
            {
                manager.AddPoints();
            }

            if (choice == "6")
            {
                Continue = false;
            }
        }
    }
}