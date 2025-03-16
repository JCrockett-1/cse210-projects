using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Manager
{
    private int _score;
    private List<Goal> _goals = new List<Goal>();
    private Random _random = new Random();
    private List<string> messages = new List<string>
    {
        "Keep going, you're doing great!",
        "One step closer to your goal!",
        "You're building a habit of success!",
        "Small steps lead to big results!",
        "Amazing! Keep pushing forward!",
        "You're unstoppable! Keep up the great work!",
        "Success is just around the corner!",
        "You're making great progress!",
        "Every goal completed is a win!",
        "Believe in yourself—you've got this!"
    };

    public Manager()
    {
        
    }

    public void AddPoints()
    {
        Console.Write("What goal did you accomplish? ");
        int goal = int.Parse(Console.ReadLine());
        int points = _goals[goal - 1].RecordEvent();
        _score += points;
        if (points > 0)
        {
            string message = messages[_random.Next(messages.Count)];
            Console.WriteLine($"Message: {message}");
        }
        Console.WriteLine($"You now have {_score} points.");
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
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].DisplayGoal()}");
        }
    }
    public void Save()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string projectDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        string fullPath = Path.Combine(projectDir, filename);

        using (StreamWriter outputFile = new StreamWriter(fullPath))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }    
        }
    }
    public void Load()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string filename = Console.ReadLine();

        string projectDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        string fullPath = Path.Combine(projectDir, filename);    

        string[] lines = System.IO.File.ReadAllLines(fullPath);
        _score = int.Parse(lines[0]);  

        _goals.Clear();

        int i = 1;
        while (i < lines.Length)
        {
            string[] parts = lines[i].Split(',');
            string type = parts[0];
            int points = int.Parse(parts[3]);
            string name = parts[1];
            string description = parts[2];
            if (type == "SimpleGoal")
            {
                bool isCompleted = bool.Parse(parts[4]); 
                _goals.Add(new SimpleGoal(points, name, description, isCompleted));
                i += 5;
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(points, name, description));
                i += 4;
            }
            else if (type == "ChecklistGoal")
            {
                int bonusPoints = int.Parse(parts[4]);
                int targetCount = int.Parse(parts[5]);
                int currentCount = int.Parse(parts[6]);
                _goals.Add(new ChecklistGoal(points, name, description, bonusPoints, targetCount, currentCount));
                i += 7;
            }
        }
    }
}