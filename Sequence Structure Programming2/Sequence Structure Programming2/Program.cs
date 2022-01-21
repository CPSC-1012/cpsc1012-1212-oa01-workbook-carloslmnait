using System;

namespace Sequence_Structure_Programming2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius, length;
            const double PI = 3.1415926535897931;

            Console.WriteLine("Enter the radius of the cylinder:");
            radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of the cylinder:");
            length = double.Parse(Console.ReadLine());

            double area = radius * radius * PI;
            double volume = area * length;

            Console.WriteLine($"The area is {area}");
            Console.WriteLine($"The colume is {volume}");
        }
    }
}
