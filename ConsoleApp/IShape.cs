using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    interface IShape
    {
        double GetPerimeter();
        double GetArea();
        void PrintShape();
    }
    class Rectangle2 : IShape
    {
        private float width;
        private float height;
        public Rectangle2(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        public float Width
        {
            get { return width; }
            set { width = value; }
        }
        public float Height
        {
            get { return height; }
            set { height = value; }
        }
        public double GetPerimeter() => width * 2 + height * 2;
        public double GetArea() => width * height;
        public void PrintShape()
        {
            Console.WriteLine($"Perimeter: {GetPerimeter()}  Area: {GetArea()}");
        }
    }
    class Circle2 : IShape
    {
        private float radius;
        public Circle2(float radius)
        {
            this.radius = radius;
        }
        public float Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public double GetPerimeter() => radius * 2 * 3.14;
        public double GetArea() => radius * radius * 3.14;

        public void PrintShape()
        {
            Console.WriteLine($"Perimeter: {GetPerimeter()}  Area: {GetArea()}");
        }
    }
}