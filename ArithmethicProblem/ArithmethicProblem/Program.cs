/*Purpose:      Sum the digits of a number
 * 
 * Inputs:      A three digit number
 * 
 * Outputs:     the sum of digits of the number
 * 
 * Algorithm:   Step 1) Prompt and read in the number
 *              Step 2) Extract right most digit from number
 *              digit1 = number %10
 *              Step 3) Remove right most digit from the number
 *              number = number / 10
 *              Step 4) Extract right most digit from number
 *              digit2 = number % 10
 *              Step 5) Remove right most digit from the number
 *              number = number / 10
 *              Step 6) Extract right most digit from number
 *              digit3 = number % 10
 *              Step 7) Remove right most digit from the number
 *              number = number / 10
 *              Step 8) Compute the sum of the digits as follows:
 *              sum = digit1 + digit2 + digit3
 * 
 * 
 * */
using System;

namespace ArithmethicProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int originalNumber,
                number,
                digit1,
                digit2,
                digit3,
                sum;

            Console.Write("Enter the number to sum digits for:")
            originalNumber = int.Parse(Console.ReadLine());

            number = originalNumber;

            digit1 = number % 10;
            number = number / 10;

            digit2 = number % 10;
            number = number / 10;

            digit3 = number % 10;
            number = number / 10;

            sum = digit1 + digit2 + digit3;

            Console.WriteLine($"The sum of the number {originalNumber} is {sum}");

        }
    }
}
