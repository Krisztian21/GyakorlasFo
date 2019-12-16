using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ismetles
{
    enum Napok { Hétfő, Kedd, Szerda, Csütörtők, Péntek, Szombat, Vasárnap }
    class Program
    {
        enum Hónapok { Január, Február, Március, Április, Május, Június, Július, Augusztus, Szeptember, Október, November, December}
        static void Main(string[] args)
        {
            //1.Feladat (Napok/Hónapok kiíratása)
            /*for (int i = 0; i < 7; i++)
            {
                Console.WriteLine((Napok)i);
            }
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine((Hónapok)i);
            */

            //2.Feladat(A bekért szám páros legyen, valószínüleg ez sem jó)
            /*int szam = 2;
            bool kiertekel = true;
            while(kiertekel&&szam>=0)
            {
                Console.WriteLine("Kérek egy számot!");
                kiertekel = !Int32.TryParse(Console.ReadLine(), out szam);
                if(szam<=0)
                {
                    kiertekel = true;
                    szam = 1;
                }
            }
            Console.WriteLine($"A bekért szám: {szam}");*/
            /*if (szam%2==0)
            {
             Console.WriteLine("Páros:"+szam);  
            }
            else
            {
             Console.WriteLine("Nem jó a szám!");
            */

            //3.Feladat (Két szám összeadása, 10-nél kissebb legyen az összeg)
            /*int szam1 = 2;
            int szam2 = 2;
            bool kiertekel1 = true;
            bool kiertekel2 = true;
            while ((kiertekel1 || kiertekel2) && (szam1 + szam2 >= 10))//ez nem jó Bodrogiét nézd meg!
            {
                Console.WriteLine("Kérek egy számot!");
                kiertekel1 = !Int32.TryParse(Console.ReadLine(), out szam1);
                Console.WriteLine("Kérek még egy számot!");
                kiertekel2 = !Int32.TryParse(Console.ReadLine(), out szam2);
                if (szam1 + szam2 > 10)
                {
                    kiertekel1 = true;
                    kiertekel2 = true;
                    szam1 = 1;
                    szam2 = 1;
                }
            }
            Console.WriteLine($"A bekért számok összege: {szam1+szam2}");*/

            //4.Feladat (Addig adjuk össze még kissebb lesz mint 100)
            /*int osszeg = 0;
            int darabszam = 0;
            int szam = 0;
            while(osszeg<=100)
            {
                Console.WriteLine("Kérek egy számot!");
                szam = Convert.ToInt32(Console.ReadLine());
                osszeg += szam;
                darabszam++;
            }
            Console.WriteLine($"A számok darabszáma: {--darabszam}, összegük: {osszeg- szam}.)*/

            //5.Feladat (Szavak összevonása szöveggé, Ez sem jó)
            /*string osszes = "";
            int osszhossz = 0;
            int darabszam = 0;
            while (osszhossz <=10)
            {
                Console.WriteLine("Kérek egy szót!");
                string elso = Console.ReadLine();
                string kimenet = "";
                //Console.WriteLine("Kérek még egy szót!");
                string masodik = Console.ReadLine();
                Console.WriteLine("Kérek egy harmadik szót (de ez nem kötelező)!");
                string harmadik = Console.ReadLine();
                Console.WriteLine("Kérek egy negyedik szót (de ez nem kötelező!");
                string negyedik = Console.ReadLine();//
                int hossz = elso.Length;
                if(osszhossz+hossz<=10)
                {
                    kimenet += elso;
                    osszhossz += hossz;
                    darabszam++;
                }
                else { break; }
                osszes = kimenet;
                //if (harmadik == "")
                {
                    osszes = elso + masodik;
                }
                else if (negyedik == "")
                {
                    osszes = elso + masodik + harmadik;
                }
                else
                {
                    osszes = elso + masodik + harmadik + negyedik;
                }//
            }
            Console.WriteLine(osszes);*/

            //6.Feladat (Fakztoriális)
            /*Console.WriteLine("Kérek egy számot!");
            int szam = Convert.ToInt32(Console.ReadLine());
            int faktorialis = 1;
            int i = 1;
            do
            {
                faktorialis *= i++;
            } while (i <= szam);
            Console.WriteLine($"A szám: {szam}, Faktoriálisa: {faktorialis*/

            //7.Feladat Bináris együtthatók
            /*for(int k=1; k<7; k++)
            {
                Console.SetCursorPosition(k*7, 0);
                Console.Write($"k= {k-1}");
            }
            for(int n=1; n<7; n++)
            {
                Console.SetCursorPosition(0, n);
                Console.Write($"n= {n - 1}");
            }
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < i+1; j++)
                {
                    Console.SetCursorPosition(j * 7, i);
                    int fakt = FaktorialSzamitas(i-1) / (FaktorialSzamitas(j-1) * FaktorialSzamitas(i - j));
                    Console.WriteLine(fakt);
                }
            }*/

            //8.Feladat Írd ki a számokat 1-20-ig és az 5-tel oszthatók ne legyenek benne
            /*for (int i = 0; i < 21; i++)
            {
                if (i % 5 != 0)
                {
                    //Console.WriteLine(i);
                    //continue; - ez csak az 5-el oszthatókat írja ki
                    //break; - ez csak kilép az if-ből
                }
                Console.WriteLine(i);
            }*/

            //9.Feladat
            /*Console.WriteLine("Kérek egy napot!");
            string nap = Console.ReadLine();
            switch (nap)
            {
                case "Hétfő":
                    //Console.WriteLine($"Szeretem a {nap}t");
                    //break;
                case "Kedd":
                    //Console.WriteLine($"Szeretem a {nap}et");
                    //break;
                case "Szerda":
                    //Console.WriteLine($"Szeretem a {nap}t");
                    //break;
                case "Csütörtők":
                    Console.WriteLine("Szeretem a hétköznapokat!");
                    //Console.WriteLine($"Szeretem a {nap}öt");
                    break;
                case "Péntek":
                    Console.WriteLine("Majdnem hétvége!");
                    //Console.WriteLine($"Szeretem a {nap}et");
                    break;
                case "Szombat":
                    //Console.WriteLine($"Szeretem a {nap}ot");
                    //break;
                case "Vasárnap":
                    Console.WriteLine("Hurrá hétvége!");
                    //Console.WriteLine($"Szeretem a {nap}ot");
                    break;
            }*/

            //10.Feladat
            /*Console.WriteLine("Kérek egy számot!");
            int szam = Convert.ToInt32(Console.ReadLine());
            switch (szam)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    Console.WriteLine("Páratlan szám!");
                    break;
                case 0:
                case 2:
                case 4:
                case 6:
                case 8:
                case 10:
                    Console.WriteLine("Páros szám!");
                    break;

            }*/

            //Kamat
            int alaposszeg = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
        }
        /*static int FaktorialSzamitas(int szam)
        {

            int faktorialis = 1;
            int index = 1;

            do
            {
                faktorialis *= index++;

            } while (index <= szam);
            return faktorialis;

        }*/
    }
}
