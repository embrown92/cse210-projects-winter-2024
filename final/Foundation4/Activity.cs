public abstract class Activity
{
    //Variables
    DateTime _date;
    protected int _minutes;


    //Constructors
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }


    //Method to calculate Pace.
    public double CalculatePace()
    {
        double pace = _minutes / CalculateDistance();
        double formatPace = double.Parse(pace.ToString("0.00"));
        return formatPace;
    }


    //Summary display method. 
    public virtual string GetSummary()
    {
        string formatDate = _date.ToString("dd MMM yyyy");
        string summary = ($"\n{formatDate} {GetType().Name} ({_minutes} min)- Distance: {CalculateDistance()} miles, Speed: {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile");
        return summary;
    }

    //Abstract methods that are overwritten in the child classes
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
}