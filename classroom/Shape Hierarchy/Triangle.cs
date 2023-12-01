namespace Shape_Hierarchy;

public class Triangle : Shape
{
    private double _firstSide;
    private double _secondSide;
    private double _thirdSide;

    private double _s;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide + secondSide <= thirdSide)
        {
            throw new ArgumentException();
        }

        if (secondSide + thirdSide <= firstSide)
        {
            throw new ArgumentException();
        }

        if (firstSide + thirdSide <= secondSide)
        {
            throw new ArgumentException();
        }

        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;

        _s = (firstSide + secondSide + thirdSide) / 2;
    }

    public override void CalculateArea()
    {
        var result = Math.Sqrt(_s * (_s - _firstSide) * (_s - _secondSide) * (_s - _thirdSide));
        Console.WriteLine("Area of triangle is: " + result);
    }

    public override void CalculatePerimeter()
    {
        var result = _firstSide + _secondSide + _thirdSide;
        Console.WriteLine("Perimeter of triangle is: " + result);
    }
}