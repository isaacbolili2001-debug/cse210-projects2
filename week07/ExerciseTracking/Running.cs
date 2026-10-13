public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60; // Speed in miles per hour
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance; // Pace in minutes per mile
    }
}