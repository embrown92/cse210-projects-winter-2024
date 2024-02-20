public class Running : Activity
{
    // Variables
    private int _distance;

    // Constructor
    public Running(DateTime date, int minutes, int distance) : base(date, minutes)
    {
        _distance = distance;
    }

    // Method for overriding the calculate distance base method
    public override double CalculateDistance()
    {
        return _distance;
    }

    // Method for overriding the calculate speed base method
    public override double CalculateSpeed()
    {
        double speed = (CalculateDistance() / _minutes) * 60;
        double formatSpeed = double.Parse(speed.ToString("0.00"));
        return formatSpeed;
    }
}