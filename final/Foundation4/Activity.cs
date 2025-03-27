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

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_activityType} ({_length} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km");
    }
}