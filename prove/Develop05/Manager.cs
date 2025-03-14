using System.Security.Cryptography.X509Certificates;

public class Manager
{
    private int _score;
    private List<Goal> _goals = new List<Goal>();

    public Manager()
    {

    }

    public int GetScore()
    {
        return _score;
    }
    public void AddGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal? ");
        string _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int _points = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            SimpleGoal sg = new SimpleGoal(_points, _name, _description, false);
            _goals.Add(sg);
        }
        else if (choice == 2)
        {
            EternalGoal eg = new EternalGoal(_points, _name, _description);
            _goals.Add(eg);
        }
        else if (choice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int _targetCount = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int _bonusPoints = int.Parse(Console.ReadLine());
            ChecklistGoal cg = new ChecklistGoal(_points, _name, _description, _bonusPoints, _targetCount);
            _goals.Add(cg);
        }
    }
    public void DisplayGoal()
    {
        Console.WriteLine("Hey");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].DisplayGoal()}");
        }
    }
    public void Save(string filename)
    {

    }
    public void Load(string filename)
    {

    }
}