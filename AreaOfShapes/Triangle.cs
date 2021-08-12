using System;

namespace AreaOfShapes
{
    public class Triangle : IShape
    {
        public double a { get; }
        public double b { get; }
        public double c { get; }
        
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Triangle sides should be positive");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Parameters are not valid. Sum of two sides should be less than third one.");
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double Area()
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
        public bool IsRight()
        {
            double x = a * a;
            double y = b * b;
            double z = c * c;

            if (x == y + z || y == x + z || z == x + y) 
                return true;
            return false;
        }
    }
}
