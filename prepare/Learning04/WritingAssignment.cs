public class WritingAssignment : Assignment
{
    private string _title;

    // WritingAssignment constructor with three parameters
    public WritingAssignment(string studentName, string topic, string title): base(studentName, topic)
    {
        // variables specific to WritingAssignment Class
        _title = title;
    }

    public string GetWritingInformation()
    {
        // call the getter here
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}