using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoValodiCharpProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Feladat: 
            string kiir = "Hello world!";
            Console.WriteLine(kiir);*/

            /* 2. Feladat:
            Console.Write("Add meg a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Üdvözöllek {nev}!");*/

            /* 3. Feladat: 
            Console.Write("Adj meg egy számot: ");
            int szam = Int32.Parse(Console.ReadLine());
            int szam = Convert.ToInt32(Console.ReadLine());
            double szam = Double.Parse(Console.ReadLine());
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A szám: {szam} kétszerese: {2 * szam}");*/

            /* 4. feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            int osszeg = szamA + szamB;
            int kulonbseg = szamA - szamB;
            int szorzat = szamA * szamA;
            double hanyados = (double)szamA / szamB;

            Console.WriteLine($"A két szám: {szamA} és {szamB}: ");
            Console.WriteLine($"Összege: {osszeg}");
            Console.WriteLine($"Különbsége: {kulonbseg}");
            Console.WriteLine($"Szorzata: {szorzat}");
            Console.WriteLine($"Hányadosa: {hanyados}");*/

            /* 5. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA > szamB)
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}");
            }
            else if (szamB > szamA)
            {
                Console.WriteLine($"A nagyobbik szám: {szamB}");
            }
            else
            {
                Console.WriteLine("A két szám egyenlő!");
            }

            if (szamA >= szamB)
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}");
            }
            else
            {
                Console.WriteLine($"A nagyobbik szám: {szamB}");
            }*/

            /* 6. Feladat: 
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.Write("Adj meg egy harmadik számot: ");
            int szamC = Convert.ToInt32(Console.ReadLine());

            if (szamA <= szamB)
            {
                if (szamA <= szamC)
                {
                    Console.WriteLine($"A legkisebb szám: {szamA}");
                }
                else
                {
                    Console.WriteLine($"A legkisebb szám: {szamC}");
                }
            }
            else
            {
                if (szamB <= szamC)
                {
                    Console.WriteLine($"A legkisebb szám: {szamB}");
                }
                else
                {
                    Console.WriteLine($"A legkisebb szám: {szamC}");
                }
            }*/

            /* 7. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.Write("Adj meg egy harmadik számot: ");
            int szamC = Convert.ToInt32(Console.ReadLine());

            if (szamA + szamB > szamC && szamA + szamC > szamB && szamB + szamC > szamA)
            {
                Console.WriteLine($"A három számból: {szamA}, {szamB} és {szamC} háromszög szerkeszthető.");
            }
            else
            {
                Console.WriteLine($"A három számból: {szamA}, {szamB} és {szamC} háromszög nem szerkeszthető.");
            }*/

            /* 8. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA >= 0 && szamB >= 0)
            {
                double szamtani = ((double)szamA + szamB) / 2;
                double mertani = Math.Sqrt(szamA * szamB);
                Console.WriteLine($"A két szám: {szamA} és {szamB} számtani közepe: {szamtani}");
                Console.WriteLine($"A két szám: {szamA} és {szamB} mértani közepe: {mertani}");
            }
            else
            {
                Console.WriteLine("A feladat nem megoldható!");
            }*/

            /* 9. - 10. Feladat:
            Console.Write("Kérse(Consolrem az első együtthatót: ");
            int a = Int32.Pae.ReadLine());
            Console.Write("Kérem a második együtthatót: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a harmadik együtthatót: ");
            int c = Int32.Parse(Console.ReadLine());
            double x1 = 0.0d;
            double x2 = 0.0d;
            int d = b * b - 4 * a * c;
            bool vanE = d < 0;
            if (vanE)
            {
                Console.WriteLine("Az egyenletnek nincsen valós megoldása.");
            }
            else
            {
                if (d == 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine($"Az egyenletnek egyetlen valós megoldása van: {x1}");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine($"Az egyenlet megoldásai: {x1} és {x2}");
                }
            }*/

            /* 11. Feladat:
            Console.Write("Kérem az első befogót: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem a második befogót: ");
            int b = Convert.ToInt32(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2) + b * b);
            Console.WriteLine($"Az átfogó hossza: {c:F2}");*/

            /* 12. Feladat:
            Console.Write("Kérem az első oldal hosszát: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem a második oldal hosszát: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem a harmadik oldal hosszát: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int f = 2 * (a * b + a * c + b * c);
            int v = a * b * c;
            Console.WriteLine($"Téglatest oldalhosszai: {a}, {b}, {c}. Felszín: {f}, térfogat: {v}");*/

            /* 13. Feladat:
            Console.Write("Kérem a kör átmérőjét: ");
            int d = Int32.Parse(Console.ReadLine());
            double k = d * Math.PI;
            double t = (Math.Pow(d, 2) * Math.PI) / 4;
            Console.WriteLine($"A kör átmérője: {d}, kerülete: {k}, területe: {t}");*/

            /* 14. Feladat:
            Console.Write("Kérem a kör sugarát: ");
            int r = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a kör központi szögét: ");
            int alfa = Int32.Parse(Console.ReadLine());
            double korivHossz = (r * Math.PI * alfa) / 180;
            double korivTerulet = (Math.Pow(r, 2) * Math.PI * alfa) / 180;
            Console.WriteLine($"A körív sugara: {r}, központi szöge: {alfa}, hossza: {korivHossz}, területe: {korivTerulet}");*/

            //15.feladat
            //Console.WriteLine("Kérem a számot!");
            //int bemenoszam = Convert.ToInt32(Console.ReadLine());
            /*for(int i=0; i<=bemenoszam;i++)
            {
                if(i==bemenoszam)
                {
                    Console.Write($"{i} ");
                }
                else
                {
                    if (i != 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }*/
            //elől tesztelő ciklus
            //int i = 1;
            /*while(i<bemenoszam)
            {
                Console.Write(i +" ");
                //i=i+1;
                //i+=1;
                //i++;
            }*/
            //hátúl tesztelő ciklus
            /*do
            {
                Console.Write(i++ + " ");
            } while (i < bemenoszam);*/

            //16.feladat
            /*Console.WriteLine("Kérem a számot!");
            int bemenoszam = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<=bemenoszam;i++)
            {
                if(i==bemenoszam)
                {
                    Console.Write("\n" + i + "\n");
                }
                else
                {
                    if (i != 0)
                    {
                        Console.Write("\n" + i + "\n");
                    }
                }
            }*/

            //17.feladat
            /*Console.WriteLine("Kérem a számot!");
            int bemenoszam = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{bemenoszam} egész osztói: ");
            for (int i = 1; i <= bemenoszam; i++)
            {
                if (bemenoszam % i == 0)
                {
                    Console.Write(i+" ");
                }
            }*/

            //18.Feladat
            /*Console.WriteLine("Kérem a számot!");
            int bemenoszam = Convert.ToInt32(Console.ReadLine());
            int db = 0;
            for (int i = 1; i < bemenoszam+1; i++)
            {
                if (bemenoszam % i == 0)
                {
                    db++;
                }
            }
                if (db == 2)
                {
                    Console.Write("A szám prímszám!");
                }
                else
                {
                    Console.Write("A szám nem prímszám!");
                }*/

            //19.Feladat
            /*Console.WriteLine("Kérem a számot!");
            int bemenoszam = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int osztokosszege = 0;
            while (i <= bemenoszam)
            {
                if (bemenoszam % i == 0)
                {
                    osztokosszege += i;
                }
                i++;
            }
            if (osztokosszege == 2*bemenoszam)
            {
                Console.WriteLine($"A {bemenoszam} tökéletes szám.");
            }
            else
            {
                Console.WriteLine($"A {bemenoszam} nem tökéletes szám.");
            }*/

            //20.feladat
            /*int alap = -1;
            while (alap <= 0 || alap > 10)
            {
                Console.WriteLine("Kérem a hatványt!");
                alap = Convert.ToInt32(Console.ReadLine());
            }
            int kitevo = -1;
            while (kitevo <= 0 || kitevo > 10)
            {
                Console.WriteLine("Kérem a kitevőt!");
                kitevo = Convert.ToInt32(Console.ReadLine());
            }
            int hatvany = 1;
            for(int i=0; i<kitevo; i++)
            {
                hatvany *= alap;
            }
            Console.WriteLine($"A hatvány alap: {alap}.");
            Console.WriteLine($"A kitevő: {kitevo}.");
            Console.WriteLine($"A hatvány érték: {hatvany}.");*/

            //21.Feladat
            /*Console.WriteLine("Kérek egy számot!");
            int szam = Convert.ToInt32(Console.ReadLine()); ;
            while (szam<=0)
            {
                Console.WriteLine("Kérek egy új számot!");
                szam = Convert.ToInt32(Console.ReadLine());
            }*/

            //21-1.Feladat
            /*Console.WriteLine("Kérek egy számot!");
            int szam = Convert.ToInt32(Console.ReadLine()); ;
            while (szam%2==0)
            {
                 Console.WriteLine("Kérek egy új számot!");
                 szam = Convert.ToInt32(Console.ReadLine());
            }

            */
            //plusz feladat prím számra lépjen ki
            /*int szam = 3;
            while(primszame(szam))
            {
                Console.WriteLine("Kérek egy prímszámot számot!");
                szam = Convert.ToInt32(Console.ReadLine());
            }*/

            //22.Feladat
            /*Console.WriteLine("Kérek egy 10-nél kissebb számot!");
            int szam = Convert.ToInt32(Console.ReadLine());
            int osszeg = 0;
            while(szam>=10)
            {
                Console.WriteLine("Új számot kérek!");
                if (szam<=10){
                    osszeg += szam;
                }
                szam = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(osszeg);*/

            //házi képen

            Console.ReadLine();
        }
        static bool primszame(int szam)
        {
            bool teljesul = true;

            int primosztokszama = 0;
            for(int i=1; i<=szam; i++)
            {
                if (szam % i == 0)
                {
                    primosztokszama++;
                }
            }
            if (primosztokszama == 2)
            {
                return teljesul;
            }
            else
            {
                return !teljesul;
            }
        }
    }
}
