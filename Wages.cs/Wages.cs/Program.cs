/* Purpose:     Compute the weekly wage of an employee
 * 
 * Inputs:      regular hourly rate
 *              regular hours worked
 *              overtime hourly rate
 *              overtime hours worked
 * 
 * Outputs:     regular wages
 *              overtime wages
 * 
 * Algorithm:   Step 1)Prompt for regular hourly rate,
 *                      regular hours worked
 *                      overtime hourly rate,
 *                      overtime hours worked
 *              Step 2) Compute the following values:
 *                          regularWages = basePay * regularHours;
                            overtimeWages = overtimePay * overtimeHours;
                               totalWages = regularWages + overtimeWages;
 *              Step 3) Display the wages for the week
 *              
 * Last modified:       2022-01-12
 * */
namespace SaleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Base Pay:");
            double basePay = double.Parse(Console.ReadLine());
            Console.Write("Enter the Regular Hours: ");
            double regularHours = double.Parse(Console.ReadLine());
            Console.Write("Enter the Overtime Pay: ");
            double overtimePay = double.Parse(Console.ReadLine());
            Console.Write("Enter the Overtime Hours: ");
            double overtimeHours = double.Parse(Console.ReadLine());

            double regularWages = basePay * regularHours;
            double overtimeWages = overtimePay * overtimeHours;
            double totalWages = regularWages + overtimeWages;

            Console.WriteLine("Regular Wages for this week are $" + regularWages);
            Console.WriteLine("Overtime Wages for this week are $" + overtimeWages);
            Console.WriteLine("Total Wages for this week are $" + totalWages);


        }
    }
}