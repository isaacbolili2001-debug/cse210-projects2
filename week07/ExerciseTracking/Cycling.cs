public class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * GetMinutes() / 60; // Distance in miles
    }

    public override double GetSpeed()
    {
        return _speed; // Speed in miles per hour
    }

    public override double GetPace()
    {
        return 60 / _speed; // Pace in minutes per mile
    }
}