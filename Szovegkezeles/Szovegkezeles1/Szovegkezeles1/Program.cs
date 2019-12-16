using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szovegkezeles1
{
    class Program
    {
        static void Main(string[] args)
        {
            //50.Feladat
            /*Console.Write("Kérem a szót! ");
            string szo = Console.ReadLine();
            for(int i=0; i<szo.Length; i++)
            {
                Console.Write(szo[i] + " ");
            }
            Console.WriteLine("\b");*/

            //51.Feladat
            /*Console.Write("Kérem a szót! ");
            string szo = Console.ReadLine();
            Console.Write("Kérem a karaktert! ");
            char karakter= Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < szo.Length; i++)
            {
                if(szo[i]!=karakter)
                {
                    Console.Write(szo[i]);
                }
            }*/

            //52.Feladat
            /*Console.Write("Kérem a szót! ");
            string szo = Console.ReadLine();
            for (int i = 0; i < szo.Length; i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(szo[i] + " ");
                }
            }*/

            //52+.Feladat
            /*Console.Write("Kérem a szót! ");
            string szo = Console.ReadLine();
            Console.Write("Kérem az indexet! ");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index<szo.Length)
            {
                Console.WriteLine($"A kereset karakter {szo[index]}");;
            }
            else
            {
                Console.Write($"Bocsi ilyen indexű karakter nincs: (0-{szo.Length-1})");k
            }*/

            //53.Feladat
            /*Console.Write("Kérem a szót! ");
            string szo = Console.ReadLine();
            int i = 0;
            while (i < szo.Length)
            {
                Console.WriteLine($"{szo[i]} - {(int)szo[i]}");
                i++;
            }*/

            //54.Feladat
            /*Console.Write("Kérem a szót! ");
            string szo = Console.ReadLine();
            for(int i=szo.Length-1; i>=0; i--)
            {
                Console.Write(szo[i]);
            }*/

            //55.Feladat
            /*Console.Write("Kérem a mondatot! ");
            string mondat = Console.ReadLine();
            for(int i=0; i<mondat.Length;i++)
            {
                if ((int)mondat[i]!=32)
                {
                    Console.Write(mondat[i]);
                }
                else
                {
                    Console.WriteLine();
                }
            }*/

            //55.Feladat (2. Megoldás)
            /*Console.Write("Kérem a mondatot! ");
            string mondat = Console.ReadLine();
            string[] tomb = mondat.Split(' ');
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }*/

            //56.Feladat
            /*Console.Write("Kérem a mondatot! ");
            string mondat = Console.ReadLine();
            string forditottszo = "";
            for (int i = mondat.Length - 1; i >= 0; i--)
            {
                forditottszo += mondat[i];
            }
            Console.WriteLine(forditottszo.ToUpper());*/

            //57.Feladat
            /*Console.Write("Kérem a mondatot! ");
            string mondat = Console.ReadLine();
            string[] tomb = mondat.Split(' ');
            for (int i = 0; i < tomb.Length; i++)
            {
                string elsobetu = tomb[i].Substring(0, 1).ToUpper();
                string maradek = tomb[i].Substring(1);
                Console.WriteLine(elsobetu + maradek);
            }*/

            //57+.Feladat //nem biztos hogy jó
            /*Console.Write("Kérem a mondatot! ");
            string mondat = Console.ReadLine();
            string[] tomb = mondat.Split(' ');
            string kiir = "";
            for (int i = 0; i < tomb.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Char ch = (char)((int)mondat[i] - 32);
                    kiir += ch;
                }
                else
                {
                    kiir += mondat[i];
                }
            }
            Console.WriteLine(kiir);*/

            Console.ReadLine();
        }
    }
}