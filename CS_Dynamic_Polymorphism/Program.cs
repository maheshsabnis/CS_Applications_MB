// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dynamic Polymorphism");

// Case 1: Creat an Instance of individual derived classes and call its method
// Provides the caller have an access of Both these  classes

//Rectangle rect = new Rectangle(100);
//Console.WriteLine($"Area of Rectangle = {rect.CalculateArea()}");
//Circle circle = new Circle(100);
//Console.WriteLine($"Area of Circle = {circle.CalculateArea()}");


// Case 2: What if the caller does not call the individual class method for area calculation

Geometry geometry = new Geometry();

// 1. Let the shape is rectangle
Shape shape = new Rectangle(500); 
geometry.FindAreaOfShape(shape);

// 2. Let the shape is Circle
shape = new Circle(500);
geometry.FindAreaOfShape(shape);

shape = new Square(900);
geometry.FindAreaOfShape(shape);

Console.ReadLine();


public abstract class Shape
{
    protected decimal height, width;

    public Shape(decimal height, decimal width)
    {
        this.height = height;
        this.width = width;
    }

    public abstract decimal CalculateArea();
     
}
/// <summary>
/// Gateway class to the Geometrical Shape System
/// </summary>
public class Geometry
{
    /// <summary>
    /// Shape is an Abstract class
    /// AT Runtime the Type of 'shape' will be set by the CLR and based on that
    /// the CalculateArea() method from the respective class will be invoked 
    /// This is "Dynamic Polymorphism"
    /// </summary>
    /// <param name="shape"></param>
    public void FindAreaOfShape(Shape shape)
    {
        decimal area = shape.CalculateArea();
        Console.WriteLine($"Area of Shape = {area}");
    }
}



public class Rectangle : Shape
{
    private decimal _SideLength = 0;
    public Rectangle(decimal sideLength) : base(sideLength, sideLength)
    {
        _SideLength = sideLength;
    }
    
    public override decimal CalculateArea()
    {
        return _SideLength * _SideLength;
    }
}

public class Circle : Shape
{
    private decimal _radius = 0;
    public Circle(decimal redius) : base(redius, redius)
    {
        _radius = redius;
    }
    public override decimal CalculateArea()
    {
        return Convert.ToDecimal(Math.PI) * _radius * _radius;
    }
}


public class Square : Shape
{
    private decimal _sides = 0;
    public Square(decimal sides) : base(sides, sides)
    {
        _sides = sides;
    }
    public override decimal CalculateArea()
    {
        return _sides * _sides; 
    }
}