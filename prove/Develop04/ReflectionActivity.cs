using System.Security.Cryptography;

public class ReflectionActivity : Activity
{
private List<string> _prompts = new List<string>
{
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless.",
    "Think of a time when you overcame a personal fear.",
    "Think of a time when you had to make a tough decision and how you handled it.",
    "Think of a time when someone unexpectedly helped you and how it made you feel.",
    "Think of a time when you had to choose kindness over anger or resentment.",
    "Think of a time when you learned an important lesson from failure.",
    "Think of a time when you pushed past your comfort zone.",
    "Think of a time when you persevered through a difficult situation and saw it through to the end.",
    "Think of a time when you felt profound gratitude.",
    "Think of a time when you found unexpected joy in a mundane task.",
    "Think of a time when you found inspiration in a challenging situation."
};

private List<string> _questions = new List<string>
{
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?",
    "How did this experience challenge you, mentally or emotionally?",
    "What was your mindset like going into it?",
    "How did you overcome any obstacles that arose?",
    "What surprised you the most while going through this experience?",
    "In what ways did this experience change your perspective?",
    "What would you do differently if you faced a similar situation again?",
    "Which moments from this experience stand out the most for you?",
    "What skills or qualities did you rely on to succeed?",
    "How can you share what you've learned from this experience with others?",
    "When you reflect on this experience, what emotions come up for you now?"
};

private List<string> _unusedPrompts;
private List<string> _unusedQuestions;
private Random _random = new Random();

public ReflectionActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
{
    _unusedPrompts = new List<string>(_prompts);
    _unusedQuestions = new List<string>(_questions);
}

public void DisplayPrompt()
{
    if (_unusedPrompts.Count == 0)
    {
        _unusedPrompts = new List<string>(_prompts);
    }

    int randomIndex = _random.Next(_unusedPrompts.Count);
    string randomPrompt = _unusedPrompts[randomIndex];

    _unusedPrompts.RemoveAt(randomIndex);

    Console.WriteLine("Consider the following prompt:");
    Console.WriteLine();
    Console.WriteLine($" --- {randomPrompt} ---");
    Console.WriteLine();
    Console.WriteLine("When you have something in mind, press enter to continue");
    
    string input = Console.ReadLine();
    if (input == "")
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write ("You make begin in: ");
        DisplayCount(5);
    }
}
public void AskRandomQuestion()
{
    if (_unusedQuestions.Count == 0)
    {
        _unusedQuestions = new List<string>(_questions);
    }

    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(_duration);
    DateTime currentTime = DateTime.Now;

    Console.Clear();
    while (currentTime < futureTime)
    {
        int randomIndex = _random.Next(_unusedQuestions.Count);
        string randomQuestion = _unusedQuestions[randomIndex];
        _unusedQuestions.RemoveAt(randomIndex);

        Console.Write($"> {randomQuestion} ");
        PauseSpinner(7);
        Console.WriteLine();
        currentTime = DateTime.Now;
    }
}

}