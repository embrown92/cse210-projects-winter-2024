using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Defualt constructor 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        // not stored as member variable
        // recomputed each time its called
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // not stored as member variable
        // recomputed each time its called
        return (double)_top/(double)_bottom;
    }

}