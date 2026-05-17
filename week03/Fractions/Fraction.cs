class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public int GetTop()
    {
        return _numerator;
    }

    public void SetTop(int top)
    {
        _numerator = top;
    }

    public int GetBottom()
    {
        return _denominator;
    }

    public void SetBottom(int bottom)
    {
        _denominator = bottom;
    }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public float GetDecimalValue()
    {
        return _numerator / (float) _denominator;
    }
}