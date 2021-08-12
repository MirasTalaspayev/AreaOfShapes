using AreaOfShapes;
using System;
using Xunit;

namespace ShapeTests
{
    public class CircleTests
    {
        private const double pi = Math.PI;
        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        public void CircleInitializationFail(double R)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var circle = new Circle(R);
            });
        }
        [Theory]
        [InlineData(25 * pi, 5)]
        [InlineData(36 * pi, 6)]
        public void CircleArea(double expected, double R)
        {
            Assert.Equal(expected, new Circle(R).Area());
        }
    }
}
