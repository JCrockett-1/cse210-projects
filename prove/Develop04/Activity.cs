public class Activity 
{

private string _name;
private string _description;
protected int _duration;

protected Activity(string name, string description)
{
    _name = name;
    _description = description;
}

public void StartActivty()
{
    Console.Clear();
    Console.WriteLine($"Wecome to the {_name}.");
    Console.WriteLine();
    Console.WriteLine(_description);
    Console.WriteLine();
    Console.Write("How long, in seconds, would you like for your session? ");
    _duration = AskDuration();

    Console.Clear();
    Console.WriteLine("Get Ready...");
    PauseSpinner(3);
    Console.WriteLine();
}

public void FinishActivty()
{
    Console.WriteLine();
    Console.WriteLine("Well done!!");
    PauseSpinner(3);
    Console.WriteLine();
    Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    PauseSpinner(3);
}

private int AskDuration()
{
    int duration = int.Parse(Console.ReadLine());
    return duration;
}

protected void PauseSpinner(int duration)
{
    for (int i = 0; i < duration; i++)
    {
        Console.Write("|");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("/");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("-");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("\\");

        Thread.Sleep(500);
        Console.Write("\b \b");
    }
}

protected void DisplayCount(int duration)
{
    for (int i = 0; i < duration; i++)
    {
        Console.Write(duration - i);
        Thread.Sleep(1000);
        Console.Write("\b \b"); 
    }
}
}