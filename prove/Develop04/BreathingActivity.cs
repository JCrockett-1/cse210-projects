using System.Runtime.CompilerServices;

public class BreathingActivity : Activity 
{

public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
{

}

public void BreatheCycle()
{
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(_duration);
    DateTime currentTime = DateTime.Now;


    while (currentTime < futureTime)
    {
        Console.WriteLine();
        Console.Write("Breathe in...");
        DisplayCount(4);
        Console.WriteLine();
        Console.Write("Now breathe out...");
        DisplayCount(6);
        Console.WriteLine();
        currentTime = DateTime.Now;
    }
}
}