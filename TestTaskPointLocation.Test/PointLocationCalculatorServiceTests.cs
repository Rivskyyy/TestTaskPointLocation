using System.Drawing;

namespace TestTaskPointLocation.Test
{
    public class PointLocationCalculatorServiceTests
    {
        private readonly PointLocationCalculatorService _service = new PointLocationCalculatorService();

        [Fact]
        public void Given_PointIsInsideSquare_When_CheckPointLocation_Than_ResultIsTrue()
        {
            //Arrange
            var squareSide = 4;
            var topLeft = new Point(1, 1);
            var checkPoint = new Point(3, -2);

            //Act
            var result = _service.CheckPointLocation(squareSide, topLeft, checkPoint);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Given_PointIsInEdgeOfSquare_When_CheckPointLocation_Than_ResultIsTrue()
        {
            //Arrange
            var squareSide = 8;
            var topLeft = new Point(0, 5);
            var checkPoint = new Point(8, 0);

            //Act
            var result = _service.CheckPointLocation(squareSide, topLeft, checkPoint);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Given_PointIsOutsideSquare_When_CheckPointLocation_Than_ResultIsFalse()
        {
            //Arrange
            var squareSide = 20;
            var topLeft = new Point(0, 0);
            var checkPoint = new Point(10, 10);

            //Act
            var result = _service.CheckPointLocation(squareSide, topLeft, checkPoint);

            //Assert
            Assert.False(result);
        }
    }
}