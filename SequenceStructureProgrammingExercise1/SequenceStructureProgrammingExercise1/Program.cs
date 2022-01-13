/* Purpose:     Displays the message with your name, age, and expected salary 
 * 
 * Inputs:      Name
 *              Age
 *              annualPay
 * 
 * Outputs:     My name is ...., my age is ...., and I hope to earn .... per year
 * 
 * Algorithm:   Step 1)Prompt for   name
 *                                  age
 *                                  annualPay
 *
 *              Step 2) Display the output
 *              
 * Last modified:       2022-01-13
 * 
 * Iteration 2:
 *          string name = "Rachel Notely";
            int age = 43;
            double annualPay = 133_404.00;

            Console.WriteLine($"My name is {name},my age is {age}, and I hope to earn ${annualPay} per year.");
 * */

namespace SequenceStructureProblem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double annualPay;

            Console.Write("Enter your name:");
            name = Console.ReadLine();

            Console.Write("Enter your age:");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter your annual income:");
            annualPay = double.Parse(Console.ReadLine());

            Console.WriteLine($"My name is {name},my age is {age}, and I hope to earn ${annualPay} per year.");
           
        }
    }
}