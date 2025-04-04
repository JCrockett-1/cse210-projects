public abstract class Activity
{
    protected string _date;
    protected double _length;
    protected string _activityType;

    public Activity(string date, double length, string activityType)
    {
        _date = date;
        _length = length;
        _activityType = activityType;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        return ($"{_date} {_activityType} ({_length} min) - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km");
    }
}