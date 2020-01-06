using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyokEgy
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember.Kiirosztaly();
            //Console.WriteLine($"Évfolyam {Ember.evfolyam}, osztály: {Ember.osztaly}.");
            //Ember[] emberTomb = new Ember[3];
            Ember[] emberTomb = new Ember[2];
            for (int i=0; i<2; i++)
            {
                bool letezik = false;
                //Console.WriteLine($"Évfolyam {Ember.evfolyam}, osztály: {Ember.osztaly}.");
                Console.Write("Kérem a magasságot: ");
                int magassag = Int32.Parse(Console.ReadLine());
                Console.Write("Kérem a test súlyt: ");
                int testsuly = Int32.Parse(Console.ReadLine());
                Console.Write("Kérem a születési évet: ");
                string szuletesiEv = Console.ReadLine();
                Ember ember = new Ember();

                try
                {
                    ember = new Ember(magassag, testsuly, szuletesiEv);
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    letezik = true;
                }

                emberTomb[i] = ember;
                ember.Kiir(i + 1);
                /*Console.WriteLine($"Az {i + 1} ember magassága: {emberTomb[i].Magassag} centiméter.");
                Console.WriteLine($"Az {i + 1} ember test súlya: {emberTomb[i].Testsuly} kilógramm.");
                Console.WriteLine($"Az {i + 1} ember születési éve: {emberTomb[i].SzuletesiEv}.");*/
                if (letezik) i--;

                /*Console.WriteLine("Második ember új magassága: ");
                int ujMagassag= Int32.Parse(Console.ReadLine());
                try
                {
                    ember = new Ember(magassag, testsuly, szuletesiEv);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    letezik = true;
                }*/
            }
            //Ember ember = new Ember(185, 81, "1998.02.15");
            Console.ReadKey(true);
        }
    }
    class Ember
    {
        private int magassag;
        private int testsuly;
        private string szuletesiEv;
        static public string osztaly = "Szoftwarefejlesztő";
        static public int evfolyam = 13;
        public int Magassag
        {
            get { return this.magassag; }
            set {
                if (value < 0 || value > 273)
                    throw new ArgumentException("Nem elfogadhato a magasság érték!");
                this.magassag = value; }
        }

        public int Testsuly
        {
            get { return this.testsuly; }
            set {
                if (value < 0)
                    throw new ArgumentException("Nem elfogadhato a test súly érték!");
                this.testsuly = value; }
        }

        public string SzuletesiEv
        {
            get { return this.szuletesiEv; }
            set { this.szuletesiEv = value; }
        }

        public Ember(int Magassag, int Testsuly, string SzuletesiEv)
        {
            if (Magassag < 0 || Magassag > 273)
                throw new ArgumentException("Nem elfogadhato a magasság érték!");
            if(Testsuly < 0)
                throw new ArgumentException("Nem elfogadhato a test súly érték!");

            this.magassag = Magassag;
            this.testsuly = Testsuly;
            this.szuletesiEv = SzuletesiEv;
        }

        public Ember()
        {

        }
        public int GetMagassag()
        {
            return this.magassag;
        }

        public void SetMagassag(int value)
        { if(value<0||value>273)
                throw new ArgumentException("Nem elfogadhato a magasság érték!");
            this.magassag = value;
        }
        public int GetTestsuly()
        {
            return this.testsuly;
        }
        public void SetTestsuly(int value)
        {
            if (value< 0)
                throw new ArgumentException("Nem elfogadhato a test súly érték!");
            this.testsuly = value;
        }
        public string GetSzuletesiEv()
        {
            return this.szuletesiEv;
        }
        public void SetSzuletesiEv(string value)
        {
            this.szuletesiEv = value;
        }

        public void Kiir(int i)
        {
            Console.WriteLine($"Az {i} ember magassága: {this.magassag}");
            Console.WriteLine($"Az {i} ember test súlya: {this.testsuly}");
            Console.WriteLine($"Az {i} ember születési éve: {this.szuletesiEv}");
            Console.WriteLine($"Az {i} ember osztálya: {evfolyam}/{osztaly}");
        }
        static public void Kiirosztaly()
        {
            Console.WriteLine($"Évfolyam {evfolyam}, osztály: {osztaly}.");
        }
    }
}
