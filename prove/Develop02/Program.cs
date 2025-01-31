using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

// I exceeded requirements by adding a system in the Prmopt class that allows none of the prompts to be repeated untill they have all been used. 
// I made a "refill" prompt list that is added to the original list when it runs out. 
// Prompts are given in a random order
class Program
{
    static void Main(string[] args)
    {
        Prompt prompts = new Prompt();
        Journal current_journal = new Journal();
        bool stop_program = false;
        while (stop_program != true)
        {
            Console.Write("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            string decision = Console.ReadLine();
            if (decision == "1")
            {
                string current_prompt = prompts.PromptDisplay();
                current_journal.NewEntry(current_prompt);
            }
            else if (decision == "2")
            {
                current_journal.Display();
            }
            else if (decision == "3")
            {
                current_journal.Load();
            }
            else if (decision == "4")
            {
                current_journal.Save();
            }
            else if (decision == "5")
            {
                stop_program = true;
            }
        }

    }
}