public abstract class Goal
{
    protected int _points;
    protected string _name;
    protected string _description;
    protected string _type;

    public Goal(int points, string name, string description, string type)
    {
        _points = points;
        _name = name;
        _description = description;
        _type = type;
    }

    public virtual string SaveGoal()
    {
        return $"{_type},{_name},{_description},{_points}";
    }

    public virtual string DisplayGoal()
    {
        return $"[ ] {_name} ({_description})";
    }

        public virtual int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points;
    }
}