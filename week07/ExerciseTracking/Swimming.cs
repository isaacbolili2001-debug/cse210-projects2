public class Swimming : Activity
{
    private int _lasps;
    public Swimming(string date, int minutes, int lasps) : base(date, minutes)
    {
        _lasps = lasps;
    }

    public override double GetDistance()
    {
        return _lasps * 50.0 / 1000 * 0.62; // Distance in miles (assuming each lap is 50 meters)
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60; // Speed in miles per hour
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance(); // Pace in minutes per mile
    }
}