public class SimpleGoal : Goal
{
private bool _isCompleted;

public SimpleGoal(int points, string name, string description, bool isCompleted) : base(points, name, description)
{

}

    public override void RecordEvent()
    {
        
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
}