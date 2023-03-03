public class Rectangle : Shape
{   
    // Attributes
    private double _lenght;
    private double _width;

    //Constructor
    public Rectangle(string color, double lenght, double _width) : base(color)
    {
        this._lenght = lenght;
        this._width = _width;
    }

    public override double GetArea()
    {
        double area = _lenght * _width;
        return area;
    }
}