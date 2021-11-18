using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laten we het paasei vinden....");
            string[,] veld = new string [10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    veld[i, j] = "-";
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(veld[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Druk op 'enter' om het spel te spelen ");
            Console.ReadLine();

            Console.WriteLine("Voer een rij nummer in van 1 tot 10 ");
            int rijNummer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Voer kolom nummer in van 1 tot 10");
            int kolomNummer = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int rij = random.Next(0, 10), kolom = random.Next(0, 10);
            int[,] paasei = new int[rij, kolom];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == rij & j == kolom)
                    {
                        veld[i, j] = ("x\t");
                    }
                    else
                    {
                        veld[i, j] = "-\t";
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(veld[i, j]);
                }
                Console.WriteLine("");
            }
            if (rijNummer== rij && kolomNummer == kolom)
            {
                Console.WriteLine("Je heb het paasei gevonden");
            }
            else if (rijNummer < rij && kolomNummer < kolom)
            {
                Console.WriteLine("ga naar boven en naar rechts");
            }
            else if (rijNummer > rij && kolomNummer < kolom)
            {
                Console.WriteLine("ga naar boven en naar rechts");
            }
            else if (rijNummer < rij && kolomNummer > kolom)
            {
                Console.WriteLine("ga naar beneden en naar links");
            }
            else if (rijNummer > rij && kolomNummer > kolom)
            {
                Console.WriteLine("ga naar boven en naar links");
            }
            Console.ReadLine();

        }
    }
}
