public abstract class Goal 
{
    // Variables
    protected string _shortname;
    protected string _description;
    protected int _points;


    // Constructor
    public Goal(string shortname, string description, int points) 
    {
        _shortname = shortname;
        _description = description;
        _points = points;
    }

    // GetName method
    public string GetName() 
    {
        return _shortname;
    }

    // Abstract RecordEvent method

    public abstract int RecordEvent();

    // Abstract IsComplete method

    public abstract bool IsComplete();


    // Virtual GetDetailsString method
    public virtual string GetDetailsString() 
    {
        return $"{_shortname} ({_description})";
    }

    // Abstract GetStringRepresentation method
    public abstract string GetStringRepresentation();
}