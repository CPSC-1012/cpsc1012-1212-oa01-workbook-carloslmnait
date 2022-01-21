using System;

namespace SequenceStructureProgramming3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side, area;

            Console.WriteLine("Enter the side of the hexagon:");
            side = double.Parse(Console.ReadLine());

            area = ((3 * Math.Sqrt(3)) / 2) * (side * side);

            Console.WriteLine($"The area of the hexagon is {area}");
        }
    }
}
