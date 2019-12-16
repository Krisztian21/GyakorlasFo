using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fugvenyek
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Feladat //nem biztos hogy jó
            /*Console.Write("Kérem egy pozitív egész számot ide:");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A(z) {szam} prím tényezői: {kettososzto(szam)}");*/

            //4.Feladat
            /*Console.Write("Kérem egy pozitív egész számot ide:");
            int szam = Convert.ToInt32(Console.ReadLine());
            int[] ermek = new int[] { 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] tomb = osztokSzama(szam);
            Console.WriteLine($"A(z) {szam} tartalmaz:");
            Console.WriteLine($"{tomb[0]} 200-as érmét");
            Console.WriteLine($"{tomb[1]} 100-as érmét");
            Console.WriteLine($"{tomb[2]} 50-es érmét");
            Console.WriteLine($"{tomb[3]} 20-as érmét");
            Console.WriteLine($"{tomb[4]} 10-es érmét");
            Console.WriteLine($"{tomb[5]} 5-es érmét");
            Console.WriteLine($"{tomb[6]} 2-es érmét");
            Console.WriteLine($"{tomb[7]} 1-es érmét");
            string kiir = $"{szam} = ";
            for(int i=0; i<tomb.Length; i++)
            {
                if(tomb[i]!=0)
                {
                    //kiir = $"{tomb[i]}*{ermek[i]} +";
                }
            }
            Console.WriteLine(kiir);
            Console.WriteLine("\b");*/

            //6.Feladat
            Console.Write("Kérem a számot! ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int[] kettes = kettesSzamrendszer(szam);
            string kiir = $"{szam} = ";
            for(int i=0; i<kettes.Length; i++)
            {
                kiir = $"{kettes[i]} +";
            }
            kiir = ")";
            Console.ReadLine();
        }
        //3.Feladat része
        /*static int kettososzto(int szam)
        {
            int osztokszama = 0;
            while (szam % 2 == 0)
            {
                osztokszama++;
                szam /= 2; //szam=szam/2;
            }
            return osztokszama;
        }*/

        //4.Feladat része
        /*static int[] osztokSzama(int szam)
        {
            int[] ermekSzama = new int[8];
            int[] oszto = new int[] { 200, 100, 50, 20, 10, 5, 2, 1 };
            for (int i = 0; i < oszto.Length; i++)
            {
                while (szam >= oszto[i])
                {
                    ermekSzama[i]++;
                    sza+m -= oszto[i]; //szam=szam/oszto;mh
                }
            }
            return ermekSzama;
        }*/

        //6.Feladat része
        static int[] kettesSzamrendszer(int szam)
        {
            int meddig = (int)Math.Floor(Math.Log(szam) / Math.Log(2));
            int[] kettesosztokSzama = new int[meddig];
            int[] kettesosztok = new int[meddig];
            for (int i = 0; i < kettesosztok.Length; i++)
            {
                kettesosztok[i] = (int)Math.Pow(2, i);
            }
                for (int i = kettesosztok.Length-1; i >=0; i--)
            {
                while (szam >= kettesosztok[i])
                {
                    kettesosztokSzama[i]++;
                    //szam -= kettesosztok[i];
                }
            }
            return kettesosztokSzama;
        }
    }
}
