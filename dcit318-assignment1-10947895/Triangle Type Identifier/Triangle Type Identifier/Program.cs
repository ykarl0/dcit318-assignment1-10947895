using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of side 1:");
            double side1 = GetSideLength();

            Console.WriteLine("Enter the length of side 2:");
            double side2 = GetSideLength();

            Console.WriteLine("Enter the length of side 3:");
            double side3 = GetSideLength();

            if (IsValidTriangle(side1, side2, side3))
            {
                string triangleType = GetTriangleType(side1, side2, side3);
                Console.WriteLine($"The triangle is: {triangleType}");
            }
            else
            {
                Console.WriteLine("The entered sides do not form a valid triangle.");
            }
        }

        static double GetSideLength()
        {
            double side;
            while (!double.TryParse(Console.ReadLine(), out side) || side <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number:");
            }
            return side;
        }

        static bool IsValidTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "Equilateral";
            }
            else if (a == b || b == c || a == c)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}