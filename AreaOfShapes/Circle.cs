using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfShapes
{
    class Circle : IShape
    {
        public double R { get; }
        public double Area() => Math.PI * R * R;
    }
}
