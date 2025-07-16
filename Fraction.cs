public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor with no parameters (default 1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with 1 parameter (whole number like 5 = 5/1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor with 2 parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for the top
    public int GetTop()
    {
        return _top;
    }

    // Setter for the top
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for the bottom
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for the bottom
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Returns fraction as string, like "3/4"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns the decimal value
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
