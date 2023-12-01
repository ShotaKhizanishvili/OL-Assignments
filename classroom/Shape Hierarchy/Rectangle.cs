namespace Shape_Hierarchy;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }

    public override void CalculateArea()
    {
        var result = _length * _width;
        Console.WriteLine("Area of rectangle is: " + result);
    }

    public override void CalculatePerimeter()
    {
        var result = 2 * (_length + _width);
        Console.WriteLine("Perimeter of rectangle is: " + result);
    }
}