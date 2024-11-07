using System;
using System.Drawing;

namespace TestTaskPointLocation
{
    internal class Program
    {
        private static readonly PointLocationCalculatorService pointLocationService = new PointLocationCalculatorService();
        private static readonly SquareDataReaderService squareDataService = new SquareDataReaderService();

        static void Main(string[] args)
        {
            var squareLength = squareDataService.ReadSquareLength();
            var squarePoint = squareDataService.ReadTopLeftCornerPoint();
            var pointLocation = squareDataService.ReadBottomRightCornerPoint();

            bool isInside = pointLocationService.CheckPointLocation(squareLength, squarePoint, squarePoint,
                 pointLocation, pointLocation);

            if (isInside)
                Console.WriteLine("\n The point is inside the square.");
            else
                Console.WriteLine("\n The point is outside the square.");

            Console.ReadKey();
        }
    }
}
