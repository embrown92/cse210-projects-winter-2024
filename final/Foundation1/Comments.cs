public class Comment
{
    // Variables for the comment class
    private string _name;
    private string _text;

    // Constructor
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // Method for displaying comment and info
    public void DisplayComments()
    {
        Console.WriteLine($"Name: {_name} \n {_text}");
    }
}