using System;

namespace ArithmeticProblem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideA,
                sideB,
                hypotenuse;

            Console.WriteLine("Enter first side:");
            sideA = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second side:");
            sideB = double.Parse(Console.ReadLine());

            hypotenuse = Math.Sqrt((sideA * sideA) + (sideB * sideB));

            Console.WriteLine($"The hypotenuse is {hypotenuse}");
        }
    }
}
