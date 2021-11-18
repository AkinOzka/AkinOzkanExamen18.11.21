using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount");
            double amount = Convert.ToDouble(Console.ReadLine());
            double finalAmount;
            finalAmount = amount - (amount * 0.05);

            if (amount>5000)
            {
                Console.WriteLine("You have won 5% discount");
                Console.WriteLine($"The Final amount you will pay: {finalAmount}");                
            }
            else
            {
                Console.WriteLine("Sorry you have won no discount...");
            }
            Console.ReadLine();
        }
    }
}
