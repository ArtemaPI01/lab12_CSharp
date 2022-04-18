using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    abstract class Shape
    {
        public abstract double GetPerimeter();
        public abstract double GetArea();
        public void PrintShape()
        {
            Console.WriteLine($"Perimeter: {GetPerimeter()}  Area: {GetArea()}");
        }
    }

    class Rectangle : Shape
    {
        private float width;
        private float height;
        public Rectangle(){}
        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        public float Width {
            get { return width; }
            set { width = value; }
        }
        public float Height 
        {
            get { return height; }
            set { height = value; }
        }
        public override double GetPerimeter() => width * 2 + height * 2;
        public override double GetArea() => width * height;
    }
    class Circle : Shape
    {
        private float radius;
        public Circle() { }
        public Circle(float radius)
        {
            this.radius = radius;
        }
        public float Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public override double GetPerimeter() => radius * 2 * 3.14;
        public override double GetArea() => radius * radius * 3.14;
    }
}