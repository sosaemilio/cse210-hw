public class Square : Shape
{
    // Attribute
    private double _side;

    //Constructor
    public Square(string color, double side) : base(color)
    {
        this._side = side;
    }
    //Methods
    public override double GetArea()
    {
        double area = Math.Pow(_side, 2);
        return area;
    }

}