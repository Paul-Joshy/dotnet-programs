using System;
delegate void Shape(int length, int breadth);
class Square
{
	public static void area(int s1, int s2)
	{
		Console.WriteLine("Area of the square is {0}", s1*s2);
	}
	public static void perimeter(int s)
	{
		Console.WriteLine("Perimeter of the square is [0]", 4*s);
	}
}

class Rectangle
{
	public static void area(int l, int b)
	{
		Console.WriteLine("Area of the Rectangle is {0}", l*b);
	}
	public static void perimeter(int l, int b)
	{
		Console.WriteLine("Perimeter of the Rectangle is {0}", 2*(l+b));
	}
}

class DelegateProg
{
    public static void Main()
    {
        Shape squareArea = new Shape(Square.area);
        Shape rectanglePerimeter = new Shape(Rectangle.perimeter);
        squareArea(5,5);
        rectanglePerimeter(4,5);
    }
}