using System.Drawing;

namespace TestTaskPointLocation
{
    public class PointLocationCalculatorService
    {
        public bool CheckPointLocation(int squareSide, Point topLeft, Point point)
        {
            if (point.X >= topLeft.X && point.X <= topLeft.X + squareSide 
                && point.Y >= topLeft.Y - squareSide && point.Y <= topLeft.Y)
                return true;
            else
                return false;
        }
    }
}
