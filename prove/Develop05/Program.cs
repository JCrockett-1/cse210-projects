using System;

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager();
        bool Continue = true;
        while (Continue == true)
        {
            Console.Clear();
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
               
            }

            if (choice == "2")
            {
                
            }

            if (choice == "3")
            {
                
            }

            if (choice == "4")
            {
                
            }

            if (choice == "5")
            {
                
            }

            if (choice == "6")
            {
                Continue = false;
            }
        }
    }
}