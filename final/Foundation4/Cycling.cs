public class Cycling : Activity
{
    // Variables
    private double _speed;

    // Constructor
    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    // Method for overriding the calculate distance base method
    public override double CalculateDistance()
    {
        double distance = (_speed * _minutes) / 60;
        double formatDistance = double.Parse(distance.ToString("0.00"));
        return formatDistance;
    }

    // Method for overriding the calculate speed base method
    public override double CalculateSpeed()
    {
        return _speed;
    }
}