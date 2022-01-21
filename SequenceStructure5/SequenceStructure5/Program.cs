using System;

namespace SequenceStructure5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double futureInvestmentValue,
                investmentAmount,
                monthlyInterestRate,
                numberOfYears;

            Console.WriteLine("Enter investment amount:");
            investmentAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the annual interest rate in percentage:");
            double annualInterestRate = double.Parse(Console.ReadLine());  
            Console.WriteLine("Enter the number of Years:");
            numberOfYears = double.Parse(Console.ReadLine());

            monthlyInterestRate = (annualInterestRate / 12 )/ 100;
            futureInvestmentValue = investmentAmount * (Math.Pow((1 + monthlyInterestRate),(numberOfYears * 12)));

            Console.WriteLine($"The future calue is ${futureInvestmentValue}");

        }
    }
}
