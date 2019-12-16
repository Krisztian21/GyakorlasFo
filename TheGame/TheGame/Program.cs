﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int szelesseg = Console.WindowWidth;
            int magassag = Console.WindowHeight;
            //Console.WriteLine($"{szelesseg} {magassag}");
            int x = szelesseg / 2;
            int y = magassag / 2;
            int[] Xkoord = new int[6];
            int[] Ykoord = new int[6];
            for(int i=0; i<6;i++)
            {
                Xkoord[i] = x + i;
                Ykoord[i] = y;
                //Console.SetCursorPosition(Xkoord[i], Ykoord[i]);
                //Console.Write("@");
            }
            Megrajzol(Xkoord, Ykoord);
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            while(cki.Key!=ConsoleKey.Escape)
            {
                cki = Console.ReadKey();
                switch(cki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        Mozgat('b', ref Xkoord, ref Ykoord);
                        Megrajzol(Xkoord, Ykoord);
                        break;
                    case ConsoleKey.UpArrow:
                        Mozgat('f', ref Xkoord, ref Ykoord);
                        Console.Clear();
                        Megrajzol(Xkoord, Ykoord);
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        Mozgat('j', ref Xkoord, ref Ykoord);
                        Megrajzol(Xkoord, Ykoord);
                        break;
                    case ConsoleKey.DownArrow: 
                        Console.Clear();
                        Mozgat('l', ref Xkoord, ref Ykoord);
                        Megrajzol(Xkoord, Ykoord);
                        break;
                }
            }
            Console.ReadKey(true);
        }
        static void Megrajzol(int[] x, int[] y)
        {
            Random rmd = new Random();
            int[] xpont = new int[];
            for (int i = 1; i < 6; i++)
            {
                Console.SetCursorPosition(x[i], y[i]);
                Console.Write("@");
            }
        }
        static void Mozgat(char merre, ref int[] x, ref int[] y)
        {
            int[] atmenetX = x;
            int[] atmenetY = y;
            for (int i = 1; i < 5; i++)
            {
                x[i] = atmenetX[i + 1];
                y[i] = atmenetY[i + 1];
            }
            switch(merre)
            {
                case 'f':
                    x[5] = atmenetX[5];
                    y[5] = atmenetY[5] - 1;
                    break;
                case 'l':
                    x[5] = atmenetX[5];
                    y[5] = atmenetY[5] + 1;
                    break;
                case 'b':
                    x[5] = atmenetX[5] - 1;
                    y[5] = atmenetY[5];
                    break;
                case 'j':
                    x[5] = atmenetX[5] + 1;
                    y[5] = atmenetY[5];
                    break;
            }
        }
    }
}
