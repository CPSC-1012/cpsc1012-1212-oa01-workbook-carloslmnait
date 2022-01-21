using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name;
            int Age;
            double annualPay;

            Console.WriteLine("Enter your name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your expected annual pay:");
            annualPay = double.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, my name is {Name}, my age is {Age} and I hope to earn ${annualPay} per year");
        }
    }
}
