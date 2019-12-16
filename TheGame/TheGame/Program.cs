using System;
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
            //Console.Write($"Szélesség: {szelesseg} Magasság: {magassag}");

            Console.SetCursorPosition(szelesseg / 2, magassag / 2);
            Console.WriteLine("@");
            Console.ReadLine();
        }
    }
}
