using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KukacTheGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rmd = new Random();
            int szelesseg = Console.WindowWidth;
            int magassag = Console.WindowHeight;
            //Console.WriteLine($"{szelesseg} {magassag}");
            int x = szelesseg / 2;
            int y = magassag / 2;
            int[] Xkoord = new int[6];
            int[] Ykoord = new int[6];
            int[] pontokx = new int[10];
            int[] pontoky = new int[10];
            for (int i = 0; i < 6;i++)
            {
                Xkoord[i] = x + i;
                Ykoord[i] = y;
                //Console.SetCursorPosition(Xkoord[i], Ykoord[i]);
                //Console.Write("@");
            }
            for (int i = 0; i < 10; i++)
            {
                pontokx[i] = rmd.Next(0, szelesseg);
                pontoky[i] = rmd.Next(0, magassag);
            }
            Megrajzol(Xkoord, Ykoord);
            Megrajzol1(pontokx, pontoky);
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            while(cki.Key!=ConsoleKey.Escape)
            {
                cki = Console.ReadKey();
                switch(cki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        Balfele(ref Xkoord, ref Ykoord);
                        Megrajzol(Xkoord, Ykoord);
                        for(int i=0; i<pontokx.Length; i++)
                        {
                            if(pontokx[i]==Xkoord[Xkoord.Length-1]&& pontoky[i] == Ykoord[Ykoord.Length - 1])
                            {
                                pontokx = EgyelCsokkent(pontokx[i], pontokx);
                                pontoky = EgyelCsokkent(pontoky[i], pontoky);
                            }

                        }
                        break;
                    case ConsoleKey.UpArrow:
                        Felfele(ref Xkoord, ref Ykoord);
                        Console.Clear();
                        Megrajzol(Xkoord, Ykoord);
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        Jobbfele(ref Xkoord, ref Ykoord);
                        Megrajzol(Xkoord, Ykoord);
                        break;
                    case ConsoleKey.DownArrow: 
                        Console.Clear();
                        Lefele(ref Xkoord, ref Ykoord);
                        Megrajzol(Xkoord, Ykoord);
                        break;
                }
            }
            Console.ReadKey(true);
        }
        static void Megrajzol(int[] x, int[] y)
        {
            for (int i = 1; i < 6; i++)
            {
                Console.SetCursorPosition(x[i], y[i]);
                Console.Write("@");
            }
        }
        static void Megrajzol1(int[] x, int[] y)
        {
            for (int i = 1; i < x.Length; i++)
            {
                Console.SetCursorPosition(x[i], y[i]);
                Console.Write("*");
            }
        }
        static void Felfele(ref int[] x, ref int[] y)
        {
            int[] atmenetX = x;
            int[] atmenetY = y;
            for (int i = 1; i < 5; i++)
            {
                x[i] = atmenetX[i + 1];
                y[i] = atmenetY[i + 1];
            }
            x[5] = atmenetX[5];
            y[5] = atmenetY[5] - 1;
        }
        static void Lefele(ref int[] x, ref int[] y)
        {
            int[] atmenetX = x;
            int[] atmenetY = y;
            for (int i = 0; i < 5; i++)
            {
                x[i] = atmenetX[i + 1];
                y[i] = atmenetY[i + 1];
            }
            x[5] = atmenetX[5];
            y[5] = atmenetY[5] + 1;
        }
        static void Jobbfele(ref int[] x, ref int[] y)
        {
            int[] atmenetX = x;
            int[] atmenetY = y;
            for (int i = 0; i < 5; i++)
            {
                x[i] = atmenetX[i + 1];
                y[i] = atmenetY[i + 1];
            }
            x[5] = atmenetX[5] + 1;
            y[5] = atmenetY[5];
        }
        static void Balfele(ref int[] x, ref int[] y)
        {
            int[] atmenetX = x;
            int[] atmenetY = y;
            for (int i = 0; i < 5; i++)
            {
                x[i] = atmenetX[i + 1];
                y[i] = atmenetY[i + 1];
            }
            x[5] = atmenetX[5] - 1;
            y[5] = atmenetY[5];
          
        }
        static void EgyelCsokkent(int szam, int[] a)
        {
            int[] b = new int[a.Length - 1];

            for(int i = 0; i < a.Length; i++)
            {
                if(szam != a[i])
                {
                    b[i] = a[i + 1];
                    i++;
                }
                else
                {
                    break;
                }
            }
            return b;
        }
    }
}
