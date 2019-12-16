using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaciFeladata
{
    class Program
    {
        static void Main(string[] args)
        {
            int bekertszam = 0;

            Random rmd = new Random();

            while (bekertszam <= 0)
            {
                try //Olyan mint az If de ez nem áll le ha nem igaz feltételt kap
                {
                    Console.Write("Adj meg egy pozitív egész számot: ");
                    bekertszam = Convert.ToInt32(Console.ReadLine());

                }

                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    //throw; //Ez ön magát elintézi azaz nem kell.
                }
            }

           Console.Write("A Bekért Számok: ");

            int[] veletlenszamok = new int[bekertszam];

            int osszeg = 0;
            int szorzat = 1;
            int egymasbolkivonas = rmd.Next(-100, 100);
            veletlenszamok[0] = egymasbolkivonas;
            osszeg += egymasbolkivonas;
            szorzat *= egymasbolkivonas;


            for (int i = 0; i < bekertszam; i++)
            {
                int generaltszam = rmd.Next(-100, 100);
                veletlenszamok[i] = generaltszam;
                osszeg += generaltszam;
                szorzat *= generaltszam;
                egymasbolkivonas -= generaltszam;
                if (i !=bekertszam-1)
                {
                    Console.Write(generaltszam + "; ");
                }
                else
                {
                    Console.WriteLine(generaltszam);
                }
            }
            Console.WriteLine($"A generált számok összege:{osszeg}");
            Console.WriteLine($"A generált számok szorzata:{szorzat}");
            Console.WriteLine($"A generált számok egymásból kivonva:{egymasbolkivonas}");
            Console.ReadKey(true);
        }
    }
}
