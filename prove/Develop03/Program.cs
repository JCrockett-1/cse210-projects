using System;
using System.Security.Principal;

// I exceeded requirements by giving the option of 3 scriptures to choose from. I also made it so it won't hide a scripture that's already hidden.

class Program
{
    static void Main(string[] args)
    {
        Reference referenceOne = new Reference("1 Nephi",2,2);
        Scripture scriptureOne = new Scripture("And it came to pass that the Lord commanded my father, even in a dream, that he should take his family and depart into the wilderness.");

        Reference referenceTwo = new Reference("3 Nephi",27,20,21);
        Scripture scriptureTwo = new Scripture("Now this is the commandment: Repent, all ye ends of the earth, and come unto me and be baptized in my name, that ye may be sanctified by the reception of the Holy Ghost, that ye may stand spotless before me at the last day. Verily, verily, I say unto you, this is my gospel; and ye know the things that ye must do in my church; for the works which ye have seen me do that shall ye also do; for that which ye have seen me do even that shall ye do;");

        Reference referenceThree = new Reference("Mosiah",3,5);
        Scripture scriptureThree = new Scripture("5 For behold, the time cometh, and is not far distant, that with power, the Lord Omnipotent who reigneth, who was, and is from all eternity to all eternity, shall come down from heaven among the children of men, and shall dwell in a tabernacle of clay, and shall go forth amongst men, working mighty miracles, such as healing the sick, raising the dead, causing the lame to walk, the blind to receive their sight, and the deaf to hear, and curing all manner of diseases.");
    
        Reference myReference;
        Scripture myScripture;
        
        Console.WriteLine("There are three scriptures. Enter a 1, 2, or 3 to select the scripture: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            myReference = referenceOne;
            myScripture = scriptureOne;
        }
        else if (choice == "2")
        {
            myReference = referenceTwo;
            myScripture = scriptureTwo;
        }
        else if (choice == "3")
        {
            myReference = referenceThree;
            myScripture = scriptureThree;
        }
        else
        {
            myReference = referenceOne;
            myScripture = scriptureOne;
        }

        bool wordsLeft = true;
        while (wordsLeft == true)
        {
            Console.Clear();
            myReference.Display();
            myScripture.Display();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (myScripture._allHidden == true)
            {
                wordsLeft = false;
            }
            else if (input == "")
            {
                for (int i = 0; i < 3; i++)
                {
                    if (myScripture._allHidden)
                    {
                        break;
                    }
                    
                    myScripture.RemoveWord();
                }
            }
            else if (input == "quit")
            {
                wordsLeft = false;
            }

        }
    }
}