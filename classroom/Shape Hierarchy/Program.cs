using Shape_Hierarchy;

Console.Write("Circle with radius ");
var radius = double.Parse(Console.ReadLine());
var circle = new Circle(radius);
circle.CalculateArea();
circle.CalculatePerimeter();

Console.Write("Rectangle with length ");
var length = double.Parse(Console.ReadLine());
Console.Write("and width ");
var width = double.Parse(Console.ReadLine());
var rectangle = new Rectangle(length, width);
rectangle.CalculateArea();
rectangle.CalculatePerimeter();

Console.Write("Enter first triangle side: ");
var firstSide = double.Parse(Console.ReadLine());
Console.Write("Enter second triangle side: ");
var secondSide = double.Parse(Console.ReadLine());
Console.Write("Enter third triangle side: ");
var thirdSide = double.Parse(Console.ReadLine());
var triangle = new Triangle(firstSide, secondSide, thirdSide);
triangle.CalculateArea();
triangle.CalculatePerimeter();