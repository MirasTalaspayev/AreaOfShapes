using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaOfShapes;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace AreaOfShapes
{
    [TestFixture]
    public class TriangleTest
    {
        //const double rootTwo = Math.Sqrt(2);
        [TestCase(3, 4, 5, ExpectedResult = 6)]
        public double AreaOfTriangle(double a, double b, double c) => new Triangle(a, b, c).Area();


    }
}