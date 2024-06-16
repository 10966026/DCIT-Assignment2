using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_and_Methods
{
    // Abstract class Shape
    abstract class Shape
    {
        // Abstract method GetArea
        public abstract double GetArea();
    }

    // Derived class Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Override GetArea method
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class Rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Override GetArea method
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Circle
            Circle circle = new Circle(5);
            Console.WriteLine($"The area of the circle is: {circle.GetArea()}");

            // Create an instance of Rectangle
            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine($"The area of the rectangle is: {rectangle.GetArea()}");

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
