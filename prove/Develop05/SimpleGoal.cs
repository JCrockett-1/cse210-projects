public class SimpleGoal : Goal
{
private bool _isCompleted;

public SimpleGoal(int points, string name, string description, bool isCompleted) : base(points, name, description)
{

}

    public override void RecordEvent()
    {
        
    }

    public override void DisplayGoal()
    {
        if (_isCompleted)
        {
            Console.WriteLine("[X] {_name} ({_description})");
        }
        else
        {
            base.DisplayGoal();
        }
    }
}