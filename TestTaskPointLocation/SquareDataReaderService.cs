using System;
using System.Drawing;


namespace TestTaskPointLocation
{
    internal class SquareDataReaderService
    {
        public int ReadSquareLength()
        {
            Console.WriteLine("\n Enter the side length of the square:");
            int squareLength = 0;

            while (true)
            {
                try
                {
                    squareLength = Convert.ToInt32(Console.ReadLine());
                    if (squareLength > 0)
                        break;
                    else
                        Console.WriteLine("Please enter a positive integer.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid integer.");
                }
            }
            return squareLength;
        }

        public Point ReadTopLeftCornerPoint()
        {
            Console.WriteLine("\n Enter the top-left corner coordinates of the square (x1, y1):");
            Point point = new Point();

            while (true)
            {
                try
                {
                    Console.Write("x1:");
                    point.X = Convert.ToInt32(Console.ReadLine());
                    Console.Write("y1:");
                    point.Y = Convert.ToInt32(Console.ReadLine());
                    break;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid integers.");
                }
            }
            return point;
        }

        public Point ReadBottomRightCornerPoint()
        {
            Console.WriteLine("\n Enter the coordinates of the point (x2, y2):");
            Point point = new Point();

            while (true)
            {
                try
                {
                    Console.Write("x2:");
                    point.X = Convert.ToInt32(Console.ReadLine());
                    Console.Write("y2:");
                    point.Y = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid integers.");
                }
            }
            return point;
        }
    }
}
