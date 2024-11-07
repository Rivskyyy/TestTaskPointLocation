using System;
using System.Drawing;

namespace TestTaskPointLocation
{
    internal class PointLocationCalculatorService
    {
        public bool CheckPointLocation(int squareSide, Point x1, Point y1, Point x2, Point y2)
        {
            if (x2.X >= x1.X && x2.X <= x1.X + squareSide && y2.Y >= y1.Y - squareSide && y2.Y <= y1.Y)
                return true;
            else
                return false;
        }
    }
}
