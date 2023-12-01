namespace Shape_Hierarchy;

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override void CalculateArea()
    {
        var result = Math.PI * Math.Pow(_radius, 2);
        Console.WriteLine("Area of circle is: " + result);
    }

    public override void CalculatePerimeter()
    {
        var result = 2 * Math.PI * _radius;
        Console.WriteLine("Perimeter of circle is: " + result);
    }
}