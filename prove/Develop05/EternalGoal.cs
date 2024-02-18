public class EternalGoal : Goal 
{
    // Constructor
    public EternalGoal (string shortname, string description, int points) : base(shortname, description, points) 
    {
        _shortname = shortname;
        _description = description;
        _points = points;
    }

    // Override RecordEvent method
    public override int RecordEvent() 
    {
        return _points;
    }

    // Override IsComplete method
    public override bool IsComplete() 
    {
        return false;
    }

    // Override GetStringRepresentation method
    public override string GetStringRepresentation() {
        return $"{_shortname}, {_description}, {_points}";
    }
}