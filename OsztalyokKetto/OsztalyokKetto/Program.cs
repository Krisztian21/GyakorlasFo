using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyokKetto
{
    class Program
    {
        static void Main(string[] args)
        {
            Megye[] megyek = new Megye[4];
            for(int i=0; i<megyek.Length; i++)
            {
                Console.WriteLine("Kérem a megyének a nevét: ");
                string nev = Console.ReadLine();
                Console.WriteLine("Kérem a megyének a területét: ");
                int terulet = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kérem a megyének a székhelyét: ");
                string megyeszekhely = Console.ReadLine();
                Console.WriteLine("Keleti megye-e?");
                bool keletiE = Boolean.Parse(Console.ReadLine());
                megyek[i] = new Megye(nev, terulet, megyeszekhely, keletiE);
                /*NyugatMagyarországiMegye nyMegye = new NyugatMagyarországiMegye (nev, terulet, megyeszekhely, nyugatiE);
                nyMegye.KiirAdatok();*/
            }
            for(int i=0; i<megyek.Length; i++)
            {
                megyek[i] = KiirAdatok;
            }
            Console.ReadKey(true);
        }
    }
    class Megye
    {
        public string Nev { get; set; }
        public int Terulet { get; set; }
        public string MegyeSzekhely { get; set; }
        public bool KeletMagyarorszagiE { get; set; }

        public Megye(string nev, int terulet, string megyeszekhely, bool keletiE)
        {
            this.Nev = nev;
            this.Terulet = terulet;
            this.MegyeSzekhely = megyeszekhely;
            this.KeletMagyarorszagiE = keletiE;
        }
        public void KiirAdatok()
        {
            if(this.KeletMagyarorszagiE)
            {
                Console.WriteLine($"A megye Neve:{this.Nev}, területe:{this.Terulet}km2, megye székhelye:{this.MegyeSzekhely}.");
            }
        }
    }
    class NyugatMagyarországiMegye : Megye
    {
        public bool NyugatMagyarországiE { get; set; }
        public NyugatMagyarországiMegye(string nev, int terulet, string megyeSzekhely, bool nyugatiE) : base(nev, terulet, megyeSzekhely)
        {
            this.NyugatMagyarországiE = nyugatiE;
        }

        new public void KiirAdatok()
        {
            if (this.NyugatMagyarországiE)
            {
                Console.WriteLine($"A megye Neve:{this.Nev}, területe:{this.Terulet}km2, megye székhelye:{this.MegyeSzekhely}.");

            }
        }
    }
}