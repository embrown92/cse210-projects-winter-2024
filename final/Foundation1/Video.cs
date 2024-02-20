public class Video
{
    // Variables for the video class
    private string _title;
    private string _author;
    private int _length;

    // List for storing comments
    public List<Comment> _comments = new List<Comment>();

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // AddComment method for adding comments to the list
    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }

    // Method for getting the number of comments
    public int GetNumOfComments()
    {
        return _comments.Count();
    }

    // Method for displaying video info
    public void DisplayVideo()
    {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length: {_length}");
        Console.WriteLine($"Number of Comments: {GetNumOfComments()}");
    }
}