using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of first side : ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of second side : ");
            double side2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of third side : ");
            double side3 = double.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
                Console.WriteLine("Equilateral triangle");
            else if (side1 == side2 || side2 == side3 || side1 == side3)
                Console.WriteLine("Isosceles triangle");
            else
                Console.WriteLine("Scalene triangle");
        }
    }
}