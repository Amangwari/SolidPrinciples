using System;

namespace OCP_FollowingExample
{


    // ------------Example that violates/Breaching the Open close priciple
    public class MyShape
    {
        public string Type { get; set; } // declaring property

        public MyShape(string type)
        {
            Type = type;
        }

        public double CalculateArea()
        {
            if (Type == "Circle")
            {
                return 3.14 * 5 * 5;
            }
            else if (Type == "Square")
            {
                return 4 * 4; 
            }
            else
            {
                throw new InvalidOperationException("Unknown shape type");
            }
        }
    }
    // ------------Example that violates/Breaching the Open close priciple









    // ------------Example that is Following the Open close priciple
    public abstract class Shape // Base class (Shape)
    {
        public abstract double CalculateArea(); // Abstract method for calculating area
    }

   
    public class Circle : Shape // Circle class (extending Shape)
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return 3.14 * Radius * Radius;
        }
    }

    
    public class Square : Shape 
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double CalculateArea()
        {
            return Side * Side; 
        }
    }

   
    public class Rectangle : Shape 
    {
        public double Length { get; set; } 
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length * Width; 
        }
    }

    class Program
    {
        //static void Main(string[] args)  // entry point 
        //{
        //    // Violation of OCP
        //    var mycircle = new MyShape("Circle");
        //    Console.WriteLine("Circle Area: " + mycircle.CalculateArea());  
        //    var mysquare = new MyShape("Square");
        //    Console.WriteLine("Square Area: " + mysquare.CalculateArea());

        //    Console.WriteLine("------");
        //    Console.WriteLine("------");

        //    // Following OCP
        //    Shape circle = new Circle(5);
        //    Console.WriteLine("Circle Area: " + circle.CalculateArea());
        //    Shape square = new Square(4);
        //    Console.WriteLine("Square Area: " + square.CalculateArea());
        //    Shape rectangle = new Rectangle(4, 6);
        //    Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
        //}
    }
}
