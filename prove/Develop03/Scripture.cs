using System;
using System.Text;
using System.Collections.Generic;

// Scripture class that stores the scripture itself 
// and displays it when called.
public class Scripture
{
    // private attributes for the Scripture class
    // that stores the reference and text of the scripture verses
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    // Constructor method  for adding new scripture that takes two parameters;
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string[] textArray = text.Split(" ");

        foreach (string word in textArray)
        {
            _words.Add(new Word(word));
        }
    }

    // Method that hides random words in the verse
    public void HideRandomWords(int numberToHide)
    {
        // generate x amount of random numbers
        Random random = new Random();
        HashSet<int> randomIndices = new HashSet<int>();
        List<int> showIndices = new List<int>();

        // Create list of index of shown words
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                showIndices.Add(i);
            }
        }

        // Number of words specified hiding logic
        if (showIndices.Count >= numberToHide)
        {
            // Get random index of shown words
            while (randomIndices.Count < numberToHide)
            {
                int randomIndex = random.Next(0, showIndices.Count);
                randomIndices.Add(showIndices[randomIndex]);
                showIndices.RemoveAt(randomIndex);
            }

            // Words from selected indices will be hidden
            foreach (int i in randomIndices)
            {
                _words[i].Hide();
            }
        }
        else
        {
            // Hide the rest of the words
            foreach (int i in showIndices)
            {
                _words[i].Hide();
            }
        }
    }

    // Method for displaying the text for the entire scripture verse/verses
    public string GetDisplayText()
    {
        // Result string
        string result = "";
        

        // Iterate through each word
        for (int i = 0; i < _words.Count; i++)
        {
            result += _words[i].GetDisplayText();
        }

        return result;
    }

    // Method to completely hide the verse
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}


