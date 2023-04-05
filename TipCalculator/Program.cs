using System.Security.Cryptography.X509Certificates;

namespace TipCalculator
{
    internal class Program
    {
        static void Main(string[] args)

        
        {

            Console.Write("Enter the total amount of the bill: ");
            double totalBill = double.Parse(Console.ReadLine());

            Console.Write("Enter the percentage of tip you want to leave: ");
            double tipPercentage = double.Parse(Console.ReadLine());

            double tipAmount = totalBill * (tipPercentage / 100);
            double totalAmount = totalBill + tipAmount;

            Console.WriteLine($"Tip amount: {tipAmount:C}");
            Console.WriteLine($"Total amount (including tip): {totalAmount:C}");

            Console.ReadLine();
        }
    }
}