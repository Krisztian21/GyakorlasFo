using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Kérem az első számot! Szám1:");
            int szam1 = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem az második számot! Szám2:");
            int szam2 = Int32.Parse(Console.ReadLine());
            Console.Write("Kérek egy nevet! Név:");
            string nev = Console.ReadLine

            Console.WriteLine($"A két szám összege: {osszead(out szam1, out szam2, out nev)}");
            Console.WriteLine($"A két szám: {szam1}, {szam2}");
            Console.WriteLine($"A név: {nev}");*/

            //ez csak egy próba
            /*Console.Write("Kérem az első számot! Szám1:");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem az második számot! Szám2:");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a harmadik számot! Szám3:");
            int c = Int32.Parse(Console.ReadLine());*/

            Console.WriteLine("1-től 100-ig vizsgálom azokat a számokat amelyek osztóinak összege osztható 7-tel!");
            for (int i = 0; i < 101; i++)
            {
                if (osszegHettel(i))
                {
                    Console.WriteLine($"{i} osztóinak összege osztható 7-tel. ");
                }
            }
            //21-1.Feladat gyorsabb vált.
            Console.WriteLine("2-től 100-ig a prímszámok: ");
            for (int i = 2; i < 101; i++)
            {
                if (primszame(i))
                {
                    Console.WriteLine(i);
                    Console.ReadLine();
                }
                Console.ReadLine();
            }
            /*static int osszead(int a, int b)
            {
                //létrehozom a visszatérő értéket
                int osszeg = 0;
                a = 128;
                b = -49;
                //kiszámolom a visszatérő értéket
                int osszeg = a + b;
                //visszaadom a visszatérő értéket
                return osszeg;


                //Két soros változat
                int osszeg = 0;
                return osszeg = a + b;
            }*/
            static bool osszegHettel(int szam)
             {
                int osszeg = 0;
                bool hettel = true;
                for (int i = 1; i < szam; i++)
                {
                    if (szam % i == 0)
                    {
                        osszeg += i;
                    }
                }
                if (osszeg % 7 != 0)
                {
                    hettel = false;
                }
                return hettel;
            }
            /*static int osszead(out int a, out int b, out string nev)
            {
                a = 0;
                b = 0;
                int osszeg = a + b;
                //a = 128;
                //b = -49;
                nev = "Attila";
                return osszeg;
            }
            /*static void tobbszoroz(int elso, int masodik, int harmadik)
            {
                elso *= 1;
                masodik *= 2;
                harmadik *= 3;
            }*/

            //Int32.TryParse használata
            int szam = 0;
            Console.Write("Kérek egy számot!");
            bool egeszSzam = Int32.TryParse(Console.ReadLine(), out szam);
            Console.Write($"A bekért szám: {szam}");
            Console.ReadLine();
        }
    }
}
