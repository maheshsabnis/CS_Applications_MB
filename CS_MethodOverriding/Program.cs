// See https://aka.ms/new-console-template for more information
Console.WriteLine("Using Method Overriding");

Console.ReadLine();


public class Shape
{
    protected decimal height, width;

    public Shape(decimal height, decimal width)
    {
        this.height = height;
        this.width = width;
    }

    public decimal CalculateArea()
    {
        return height * width;
    }
}

public  class Rectangle : Shape
{
    private decimal _SideLength = 0;
    public Rectangle(decimal sideLength):base(sideLength,sideLength)
    {
        _SideLength = sideLength;
    }
    // Shadow
    public new decimal CalculateArea()
    { 
        return _SideLength * _SideLength;
    }
}

public class Circle : Shape 
{
    private decimal _radius = 0;
    public Circle(decimal redius):base(redius,redius)
    {
        _radius = redius;
    }
    // Shadow
    public new decimal CalculateArea()
    {
        return Convert.ToDecimal(Math.PI) * _radius * _radius;
    }
}
