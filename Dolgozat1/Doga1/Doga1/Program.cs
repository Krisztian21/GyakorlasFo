using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem a geomatriai forma nevet (kör, téglalap, négyzet, derékszögű háromszög / háromszög)!");
            string nev = Console.ReadLine();
            if (nev == "kör")
            {
                Console.Clear();
                Console.Write("Adja meg a kör sugarát! ");
                double sugar = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"A kör sugara: {sugar}");
                double kerulet = sugar * sugar * Math.PI;
                Console.Write($"A kör kerulete: {kerulet}");
                double terulet = 2 * sugar * Math.PI;
                Console.Write($"A kör terulete: {terulet}");
            }
            else if (nev == "téglalap")
            {
                Console.Clear();
                Console.Write("Adja meg a téglalap a oldalát! ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Adja meg a téglalap b oldalát! ");
                double b = Convert.ToDouble(Console.ReadLine());
                double kerulet = (a + b) * 2;
                Console.WriteLine($"A téglalap kerulete: {kerulet}");
                double terulet = a + b;
                Console.Write($"A téglalap terulete: {terulet}");
            }
            else if (nev == "négyzet")
            {
                Console.Clear();
                Console.Write("Adja meg a négyzet a oldalát! ");
                double a = Convert.ToDouble(Console.ReadLine());
                double kerulet = a * 4;
                Console.WriteLine($"A négyzet kerulete: {kerulet}");
                double terulet = a * a;
                Console.Write($"A négyzet terulete: {terulet}");
            }
            else if (nev == "derékszögű háromszög"|| nev == "háromszög")
            {
                Console.Clear();
                Console.Write("Adja meg a háromszög a oldalát! ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Adja meg a háromszög b oldalát! ");
                double b = Convert.ToDouble(Console.ReadLine());
                double c_negyzet = (a * a) + (b * b);
                double c = Math.Sqrt(c_negyzet);
                double kerulet = a + b + c;
                Console.WriteLine($"A háromszög a {a} b {b} és c {c} oldala!");
                Console.WriteLine($"A háromszög kerulete: {kerulet}");
                double terulet = (a*b)/2;
                Console.Write($"A háromszög terulete: {terulet}");
            }
            else
            {
                Console.Clear();
                Console.Write("Rossz szót adott meg!");
            }
            Console.ReadLine();
        }
    }
}
