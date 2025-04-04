public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, double length, double laps) : base(date, length, "Swimming")
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return _laps * 50 / 1000 / _length * 60;
    }

    public override double GetPace()
    {
        return _length / (_laps * 50 / 1000);
    }

}