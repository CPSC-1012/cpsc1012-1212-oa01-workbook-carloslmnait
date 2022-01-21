/*Purpose:  To write a program that equivalents into a reciept (includes Taxes, SubTotal, and Sum calculations)
 * 
 * Input: Item Price and Quantity
 * 
 * Output: sum, average
 * 
 * Written by: Melchor,Carlos Louise
 * 
 * Written for: Wu, Sam
 * 
 * Section OA01
 * 
 * */
using System;

namespace CPSC1012_Lab01_Melchor_CarlosLouise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double itemPrice;
            double quantity;
            double subTotal;
            double totalTax;
            double totalPrice;
            const double ProvincialTaxRate = 0.06;
            const double FederalTaxRate = 0.05;
            double provincialSalesTax;
            double federalSalesTax;

            //Opening Message and Item Prompt
            Console.WriteLine("************Welcome to the General Store************");

            Console.Write("Please enter the price of an item:");
            itemPrice = double.Parse(Console.ReadLine());

            Console.Write("Please enter the quantity being purchased:");
            quantity = double.Parse(Console.ReadLine());

            //subTotal calculations
            subTotal = Math.Round((itemPrice * quantity), 2);

            //Taxes calculations
            provincialSalesTax = Math.Round((subTotal * ProvincialTaxRate), 2);
            federalSalesTax = Math.Round((subTotal * FederalTaxRate), 2);
            totalTax = Math.Round((provincialSalesTax + federalSalesTax), 2);

            //Total Price calculation / Sum
            totalPrice = Math.Round((subTotal + totalTax), 2);

            //Invoice Summary Message
            Console.WriteLine("Invoice Summary");
            Console.WriteLine("=========================");

            //Invoice Summary / Costs
            Console.WriteLine($"Sub Total:       {subTotal} " +
                $"\n\nProvincial Tax:   {provincialSalesTax} " +
                $"\nFederal Tax:      {federalSalesTax} " +
                $"\nTotal Tax:        {totalTax} " +
                $"\n\nTotal Price:     {totalPrice}");
            
            // Thank You message & end of invoice
            Console.WriteLine("=========================\n\nThank you for your purchase, come again..\nPress any key to exit");

        }
    }
}
