public class Manager
{
    private int _score;
    private List<Goal> _goals;

    public Manager()
    {

    }

    public int GetScore()
    {
        return _score;
    }
    public void AddGoal(Goal goal)
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        Console.ReadLine();
        
        Console.Write("What is the name of your goal? ");
        Console.ReadLine();
        Console.Write("What is a short description of it? ");
        Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        Console.ReadLine();


        
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? 3");
        Console.WriteLine("What is the bonus for accomplishing it that many times? 500");

    }
    public void DisplayGoal()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].DisplayGoal}");
        }
    }
    public void Save(string filename)
    {

    }
    public void Load(string filename)
    {

    }
}