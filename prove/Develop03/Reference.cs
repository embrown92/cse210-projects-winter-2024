using System;

public class Reference
{
    // Private variables for the Reference class that hold scripture info
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructor for single-verse reference
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Constructor for multiple verse reference
     public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Method for getting scripture reference string
    public string GetDisplayText()
    {
        // If end of verse exists, include it in the display text.
        // Otherwise, don't.
        if (_endVerse != 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    } 
}