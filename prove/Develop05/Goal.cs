public abstract class Goal
{
    private int _points;
    private string _name;
    private string _description;

    public Goal(int points, string name, string description)
    {

    }

    public abstract void RecordEvent();
    public virtual void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }
}