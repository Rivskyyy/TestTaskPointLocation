using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskPointLocation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int squareSide;
            int x1;
            int y1;

            int x2;
            int y2;

            GetSquareLength(out squareSide);
            GetTopLeftCorner(out x1, out y1);
            GetPoint(out x2, out y2);
            GetPointLocation(squareSide, x1, y1, x2, y2);

        }
        private static void GetSquareLength(out int squareSide)
        {
            Console.WriteLine("\n Enter the side length of the square:");

            while (true)
            {
                try
                {
                    squareSide = Convert.ToInt32(Console.ReadLine());
                    if (squareSide > 0)
                        break;
                    else
                        Console.WriteLine("Please enter a positive integer.");
                }
                catch
                {
                    Console.WriteLine("Please enter a valid integer.");
                }
            }
        }

        private static void GetTopLeftCorner(out int x1, out int y1)
        {
            Console.WriteLine("\n Enter the top-left corner coordinates of the square (x1, y1):");

            while (true)
            {
                try
                {
                    Console.Write("x1:");
                    x1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("y1:");
                    y1 = Convert.ToInt32(Console.ReadLine());
                    break;

                }
                catch
                {
                    Console.WriteLine("Please enter valid integers.");
                }
            }
        }
        private static void GetPoint(out int x2, out int y2)
        {
            Console.WriteLine("\n Enter the coordinates of the point (x2, y2):");

            while (true)
            {
                try
                {
                    Console.Write("x2:");
                    x2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("y2:");
                    y2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Please enter valid integers.");
                }
            }
        }

        private static void GetPointLocation(int squareSide, int x1, int y1, int x2, int y2)
        {
            if (x2 >= x1 && x2 <= x1 + squareSide && y2 >= y1 - squareSide && y2 <= y1)
            {
                Console.WriteLine("\n The point is inside the square.");
            }
            else
            {
                Console.WriteLine("\n The point is outside the square.");
            }
            Console.ReadKey();
        }      
    }
}
