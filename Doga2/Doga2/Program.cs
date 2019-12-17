using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hány szavas legyen a mondat? ");
            int mondathossz = Convert.ToInt32(Console.ReadLine());//Ez a sor a mondat hosszúsága
            string[] mondat = new string[mondathossz];
            Random rmd = new Random ();
            
            for(int i=0; i < mondat.Length; i++)
            {
                int szavakhossza = rmd.Next(1, 12);
                string szavak = "";
                while (szavak.Length != szavakhossza)
                {
                    Console.Write($"Kérem a következő {szavakhossza} betűszámú szót: ");
                    szavak = Console.ReadLine();
                }
                mondat[i] = szavak;
            }

            Console.Write($"A mondat:");

            for (int i = 0; i < mondat.Length; i++)
            {
                if (i != mondat.Length - 1)
                {
                    Console.Write(mondat[i] + " ");
                }
                else
                {
                    Console.Write(mondat[i] + ".");
                }
            }
            Console.ReadLine();
        }
    }
}
