using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzandiekDogaja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Alapösszeg: ");
            double osszeg = Int32.Parse(Console.ReadLine());
            double alaposszeg = osszeg;
            double evesosszeg = osszeg;
            Console.Write("Kamatláb: ");
            double kamat = Int32.Parse(Console.ReadLine());
            Console.Write("Futamidő: ");
            int futamido = Int32.Parse(Console.ReadLine());
            Console.SetCursorPosition(13, 4);
            Console.WriteLine("Évenkénti összeg");
            Console.SetCursorPosition(32, 4);
            Console.WriteLine("Összhozam");
            Console.SetCursorPosition(45, 4);
            Console.WriteLine("Éves hozam");
            for (int i=0; i<futamido;i++)
            {
                osszeg = (kamat/100+1)*osszeg;
                Console.SetCursorPosition(13, 5 + i);
                Console.Write($"\n{i + 1}. év végen: {osszeg:F0}Ft");
                Console.SetCursorPosition(32, 5 + i);
                Console.Write($"{osszeg - alaposszeg:F0}Ft");
                Console.SetCursorPosition(45, 5 + i);
                Console.Write($"{osszeg - evesosszeg:F0}Ft");//hoho
            }

            Console.ReadKey(true);
        }
    }
}
