using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitElso
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write($"Kérem az első számot: ");
            int elsoszam = Convert.ToInt32(Console.ReadLine());
            Elso elso = new Elso(elsoszam); //Class-os megoldás
            Console.Write($"Kérem a második számot: ");
            int masodikszam = Convert.ToInt32(Console.ReadLine());
            Elso masodik = new Elso(masodikszam); //Class-os megoldás

            Console.WriteLine($"A két szám összege: {Sum(elsoszam, masodikszam)}"); //static void megoldás
            Console.WriteLine($"A 2 szám összege: {elso.Sum(masodik)}"); //Class-os megoldás
            Console.WriteLine($"A 2 szám összege: {masodik.Sum(elso)}"); //Class-os */


            /*Console.Write($"Kérem a számot: ");
            int szamMeg1 = Convert.ToInt32(Console.ReadLine());
            Elso elsoPlusz1 = new Elso(szamMeg1);//Nem jó
            Console.WriteLine($"A szám + 1 összege: {szampluszegy(szamMeg1)}"); //static void megoldás
            Console.WriteLine($"A szám + 1 összege: {elsoPlusz1.szampluszegy()}");//Nem jó*/

            /*Console.Write($"Kérem az első számot: ");
            double elsoszam = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Kérem a második számot: ");
            double masodikszam = Convert.ToInt32(Console.ReadLine());
            Haromszog haromszog = new Haromszog(elsoszam, masodikszam);
            Console.WriteLine($"A háromszög területe: {Haromszog(elsoszam, masodikszam)}"); //static void megoldás*/
            //Console.WriteLine($"A 2 szám összege: {elsoszam.Terulet()}"); //Class-os //Nem jó


            /*Console.Write($"Kérem az első számot: ");
            int elsoszam = Convert.ToInt32(Console.ReadLine());
            Elso elso = new Elso(elsoszam);
            Console.Write($"Kérem a második számot: ");
            int masodikszam = Convert.ToInt32(Console.ReadLine());
            Elso masodik = new Elso(masodikszam);
            Console.WriteLine($"A 2 szám elosztva: {SzamOsztvaSzammal(elsoszam, masodikszam)}");
            Console.WriteLine($"A két szám maradéka: {elso.Maradek(masodik)}");*/ //ez sem müködik

            /*Console.Write($"Kérem az első számot: ");
            int elsoszam = Convert.ToInt32(Console.ReadLine());
            Elso elso = new Elso(elsoszam);
            Console.WriteLine($"A 2 szám elosztva: {Elojel(elsoszam)}");*/ // ez egyáltalán nem müködik

            /*Console.Write("Kérem a logikai értéket: ");
            //bool ert = 12 < 25;
            bool elsoszam = Convert.ToBoolean(Console.ReadLine());
            Elso elso = new Elso(elsoszam);
            Console.WriteLine($"A logikai értéke negatívja: {Megfordit(elsoszam)}");*/ //ez sem jó

            /*Console.Write($"Kérem a számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Elso elso = new Elso(szam);
            Elso masodik = new Elso(5);
            Console.WriteLine($"A szám osztható-e 5-tel: {oszthato_5_tel(szam)}");
            Console.WriteLine($"A szám osztható-e öttel: {elso.Otteloszthato()}");
            Console.WriteLine($"A szám osztható-e öttel: {elso.Otteloszthato(masodik)}");*/

            Console.Write($"Kérem az első szót: ");
            string szo1 = Console.ReadLine();
            Sztringek elso = new Sztringek(szo1);
            Console.Write($"Kérem az második szót: ");
            string szo2 = Console.ReadLine();
            Sztringek masodik = new Sztringek(szo2);
            Sztringek egyutt = new Sztringek(szo1, szo2);
            Console.WriteLine($"A 2 szó egyenlő hosszúak-e: {elso.EgyenloHoszuakE(masodik)}");
            //Console.WriteLine($"A két String összefűzve: {egyutt.osszefuz()}");
            Console.WriteLine($"Van-e space: {elso.van_eSpace()}");
            Console.WriteLine($"Van_e space: {masodik.van_eSpace()}");
            Console.ReadLine();
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int szampluszegy(int szam1)
        {
            return szam1 + 1;
        }

        static double Haromszog(double a1, double b1)
        {
            return a1 * b1 / 2;
        }
        static int SzamOsztvaSzammal(int szam1, int szam2)
        {
            return szam1 % szam2;
        }
        static bool Elojel(int a)
        {
            if (a <= 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        static bool Megfordit(bool logikaiertek)
        {
            return logikaiertek;
        }

        static bool oszthato_5_tel(int a)
        {
            if (a % 5== 0)
            {
                return true;

            }
            else
            {
                return false;

            }
        }
    }
}
