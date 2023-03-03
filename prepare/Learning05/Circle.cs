public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        this._radius = radius;
    }

    public override double GetArea()
    {
        double area = Math.PI * (_radius * _radius);
        return area;
    }
}