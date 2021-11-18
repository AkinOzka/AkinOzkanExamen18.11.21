using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] postnumber = new int[] { 9300, 2000, 1000, 9200, 9000, 8500, 9700, 2300};
            string[] nameCity = new string[] { "Aalst", "Antwerpen","Brussel", "Dendermonde", "Gent", "Kortrijk", "Oudenaarde", "Turnhout"};
            Console.WriteLine("Please enter the postnumber of the stad");
            int postnumberEntered = Convert.ToInt32(Console.ReadLine());
            int counter=0;
            for (int i = 0; i < postnumber.Length; i++)
            {
                if (postnumber[i]==postnumberEntered)
                {
                    Console.WriteLine(nameCity[i]);
                    counter++;
                }
            }
            if (counter==0)
            {
                Console.WriteLine("You have entered a wrong postnumber!!!");
            }
            Console.ReadLine();
        }
    }
}
