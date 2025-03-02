using System.Net;

public class ListingActivity : Activity
{

private int _countOfResponses = 0;
private List<string> _prompts = new List<string>
{
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?",
    "What is something you recently accomplished that you are proud of?",
    "Who has inspired or uplifted you lately?",
    "In what ways have you seen God's hand in your daily life?",
    "What is one small blessing you noticed today?",
    "How can you express more gratitude for the people around you?",
    "When did you last feel a strong sense of peace or comfort?",
    "What new insight or lesson have you learned about yourself recently?",
    "Who is someone you can show kindness to this week?",
    "What talents or gifts do you feel you have been blessed with?",
    "What simple act of service could you perform in the next few days?"
};
    private List<string> _unusedPrompts;
public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
{
    _unusedPrompts = new List<string>(_prompts);
}
public void CollectResponses()
{
    if (_unusedPrompts.Count == 0)
    {
        _unusedPrompts = new List<string>(_prompts);
    }

    Random random = new Random();
    int randomIndex = random.Next(_unusedPrompts.Count);
    string randomPrompt = _unusedPrompts[randomIndex];

    _unusedPrompts.RemoveAt(randomIndex);

    Console.WriteLine("List as many responses you can to the following prompt:");
    Console.WriteLine($" --- {randomPrompt} ---");
    Console.Write("You may begin in: ");
    DisplayCount(5);
    Console.WriteLine();

    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(_duration);
    DateTime currentTime = DateTime.Now;

    while (currentTime < futureTime)
    {
        Console.Write("> ");
        Console.ReadLine();
        _countOfResponses += 1;
        currentTime = DateTime.Now;
    }
}

public void DisplayResponsesCount()
{
    Console.WriteLine($"You listed {_countOfResponses} times!");
}

}