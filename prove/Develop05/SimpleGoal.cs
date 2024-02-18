public class SimpleGoal : Goal 
{
    // Varible
    private bool _isComplete;

    // Constructor
    public SimpleGoal(string shortname, string description, int points, bool isComplete) : base(shortname, description, points) 
    {
        _shortname = shortname;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    // Override RecordEvent method
    public override int RecordEvent() 
    {
        _isComplete = true;
        return _points;
    }

    // Override IsComplete method
    public override bool IsComplete() 
    {
        return _isComplete;
    }

    // Override GetStringRepresentation method
    public override string GetStringRepresentation() 
    {
        return $"{_shortname},{_description},{_points},{_isComplete}";
    }
}