using System;

namespace SequenceStructureProgramming4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;             // A number between 0 and 1000
            int sumOfDigits = 0;    // The sum of the digits in number
            int digit;              // The digit extracted from the number
            int tempNumber;         // A copy of the number

            // Prompt for the number
            Console.Write("Enter a number between 0 and 1000: ");
            // Read in the number
            number = int.Parse(Console.ReadLine());
            tempNumber = number;

            // Extract the first right most digit
            digit = tempNumber % 10;
            // Add the digit to the sum
            sumOfDigits += digit;
            // Remove the right most digit from the number
            tempNumber = tempNumber / 10;

            // Extract the next (2nd) digit from number
            digit = tempNumber % 10;
            // Add the digit to the sum
            sumOfDigits += digit;
            // Remove the right most digit from the number
            tempNumber = tempNumber / 10;

            // Extract the next (3rd) digit from number
            digit = tempNumber % 10;
            // Add the digit to the sum
            sumOfDigits += digit;

            // The last digit extracted by dividing by 10
            digit = tempNumber / 10;
            sumOfDigits += digit;

            // Display the sum 
            Console.WriteLine($"The sum of the digits is {sumOfDigits} for {number}");

        }
    }
}
