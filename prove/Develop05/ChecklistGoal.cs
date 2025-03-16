public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _targetCount;
    private int _currentCount;

    public ChecklistGoal(int points, string name, string description, int bonusPoints, int targetCount) : base(points, name, description, "ChecklistGoal")
    {
        _bonusPoints = bonusPoints;
        _targetCount = targetCount;
    }

    public ChecklistGoal(int points, string name, string description, int bonusPoints, int targetCount, int currentCount) : base(points, name, description, "ChecklistGoal")
    {
        _bonusPoints = bonusPoints;
        _targetCount = targetCount;
        _currentCount = currentCount;
    }
    public override string SaveGoal()
    {
        return $"{_type},{_name},{_description},{_points},{_bonusPoints},{_targetCount},{_currentCount}";
    }
    public override string DisplayGoal()
    {
        if (_currentCount == _targetCount)
        {
            return $"[X] {_name} ({_description}) -- Currently completed: {_currentCount}/{_targetCount}";
        }
        else
        {
            return $"[ ] {_name} ({_description}) -- Currently completed: {_currentCount}/{_targetCount}";
        }
    }
    
    public override int RecordEvent()
    {
        if (_currentCount == _targetCount)
        {
            Console.WriteLine("Goal has already been completed.");
            return 0;
        }
        else if (_currentCount + 1 == _targetCount)
        {
            Console.WriteLine($"Congratulations! You have earned {_points + _bonusPoints} points!");
            _currentCount += 1;
            return _points + _bonusPoints;
        }    
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            _currentCount += 1;
            return _points;
        }
    }
}