using System;

namespace ArithmethicProblem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            double  number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            double number3 = double.Parse(Console.ReadLine());

            double mean = (number1 + number2 + number3) / 3;

            Console.WriteLine($"The mean is {mean}");
        }
    }
}
