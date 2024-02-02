using System;

// Word class that holds the words to make up the scripture.
// It also handles all the methods for hiding and rending hidden words.
public class Word
{
    // These are the private attributes of the Word class
    private string _text;
    private bool _isHidden;

    // Constructor thst takes no parameters
    public Word()
    {
        _text = "Trust in the LORD with all your heart, and do not lean on your own understanding. In all your ways acknowledge Him, and He will make straight your paths.";
    }

    // Constructor that takes a string parameter 'text' 
    // and assigns it to the private attribute '_text_'
    public Word(string text)
    {
        this._text = text;
        _isHidden = false;
    }

    // Hide method
    public void Hide()
    {
        _isHidden = true;
    }

    // getWord method
    public void Show()
    {
        _isHidden = false;
    }

    // IsHidden method
    public bool IsHidden()
    {
        return _isHidden;
    }
    // GetDisplayText method
    public string GetDisplayText()
    {
        if (_isHidden == false)
        {
            return _text + " ";
        }
        else
        {
            string hiddenText = new string('_', _text.Length) + " ";
            return hiddenText;
        }
    }



}

