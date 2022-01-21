using System;

namespace ArithmeticProblem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sumOfDigits = 0;
            int digit;
            int tempNumber;

            Console.Write("Enter a three digit number: ");
            number = int.Parse(Console.ReadLine());
            tempNumber = number;

            digit = tempNumber % 10;
            sumOfDigits += digit;
            tempNumber = tempNumber / 10;

            digit = tempNumber % 10;
            sumOfDigits += digit;
            tempNumber = tempNumber / 10;

            digit = tempNumber % 10;
            sumOfDigits += digit;

            digit = tempNumber / 10;
            sumOfDigits += digit;

            // Display the sum 
            Console.WriteLine($"The sum of the digits is {sumOfDigits} for {number}");
        }
    }
}
