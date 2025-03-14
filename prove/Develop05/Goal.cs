public abstract class Goal
{
    protected int _points;
    protected string _name;
    protected string _description;

    public Goal(int points, string name, string description)
    {

    }

    public abstract void RecordEvent();
    public virtual string DisplayGoal()
    {
        return $"[ ] {_name} ({_description})";
    }
}