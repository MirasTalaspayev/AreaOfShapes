using AreaOfShapes;
using System;
using Xunit;

namespace ShapeTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(6, 3, 4, 5)]
        [InlineData(1.5, 1.5, 2, 2.5)]
        public void TriangleArea(double expected, double a, double b, double c)
        {
            Assert.Equal(expected, new Triangle(a, b, c).Area());
        }
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(5, 5, 10)]
        [InlineData(0, 2, 3)]
        public void TriangleInitializationFail(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Triangle(a, b, c);
            });
        }
        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(9, 12, 15)]
        public void TriangleIsRight(double a, double b, double c)
        {
            Assert.True(new Triangle(a, b, c).IsRight());
        }
        
    }
}
