public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        this._color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string shapeColor)
    {
        this._color = shapeColor;
    }

    public abstract double GetArea();
}