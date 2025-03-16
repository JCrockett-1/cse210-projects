public class SimpleGoal : Goal
{
private bool _isCompleted;

public SimpleGoal(int points, string name, string description, bool isCompleted) : base(points, name, description, "SimpleGoal")
{
_isCompleted = isCompleted;

}

    public override string SaveGoal()
    {
        return $"{_type},{_name},{_description},{_points},{_isCompleted}";
    }

    public override string DisplayGoal()
    {
        if (_isCompleted)
        {
            return $"[X] {_name} ({_description})";
        }
        else
        {
            return base.DisplayGoal();
        }
    }

    public override int RecordEvent()
    {
        if (_isCompleted == false)
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            _isCompleted = true;
            return _points;
        }
        else
        {
            Console.WriteLine("Goal has already been completed.");
            return 0;
        }
    }
}