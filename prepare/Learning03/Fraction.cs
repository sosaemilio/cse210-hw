public class Fraction
{   //Attributes
    private int _top;
    private int _bottom;

    // Constructor
    public Fraction()
    {
        this._bottom = 1;
        this._bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        this._top = wholeNumber;
        this._bottom = 1;
    
    }

    public Fraction(int top, int bottom)
    {
        this._top = top;
        this._bottom = bottom;
    }

    // Settler and Getter
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        this._top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        this._bottom = bottom;
    }

    public string GetFractionString()
    {
        string franctionString = _top.ToString() + "/" + _bottom.ToString();
        return franctionString;
    }

    /*
    public double GetDecimalValue()
    {

    }
    */
}