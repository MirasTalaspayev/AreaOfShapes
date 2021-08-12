using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfShapes
{
    public class Circle : IShape
    {
        public double R { get; }
        public Circle(double R)
        {
            if (R <= 0)
                throw new ArgumentException("Radius should be positive");
            this.R = R;
        }
        public double Area() => Math.PI * R * R;
    }
}
