public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _targetCount;
    private int _currentCount;

    public ChecklistGoal(int points, string name, string description, int bonusPoints, int targetCount) : base(points, name, description)
    {
        
    }
    public override void RecordEvent()
    {

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
}