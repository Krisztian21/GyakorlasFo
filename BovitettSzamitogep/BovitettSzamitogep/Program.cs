using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BovitettSzamitogep
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Kérem az első számot!");
                int elso = Convert.ToInt32(Console.ReadLine());
                Szam elsoSzam = new Szam(elso);
                Console.WriteLine("Kérem az második számot!");
                int masodik = Convert.ToInt32(Console.ReadLine());
                Szam masodikSzam = new Szam(masodik);
                Console.WriteLine("Kérem az harmadik számot!");
                int harmadik = Convert.ToInt32(Console.ReadLine());
                Szam harmadikSzam = new Szam(harmadik);

                elsoSzam.ElsoKertSzamOsszege(masodikSzam);
                elsoSzam.ElsoKertSzamKivonasa(masodikSzam);
                elsoSzam.ElsoKertSzamSzorzata(masodikSzam);
                elsoSzam.ElsoKertSzamOsztaleka(masodikSzam);
                elsoSzam.SzamokSzamtaniKozepe(masodikSzam, harmadikSzam);
                elsoSzam.SzamokMertaniKozepe(masodikSzam, harmadikSzam);
                elsoSzam.SzamokMertaniKozepe2(masodikSzam, harmadikSzam);


            }
            catch (Exception e)
            {
                throw;
            }
            Console.ReadLine();
        }
    }
    class Szam
    {
        public int BekertErtek { get; set; }
        public Szam(int bekert)
        {
            this.BekertErtek = bekert;
        }
        public void ElsoKertSzamOsszege(Szam szam)
        {
            Console.WriteLine($"Az első két szám összege: {this.BekertErtek+szam.BekertErtek}.");
        }
        public void ElsoKertSzamKivonasa(Szam szam)
        {
            Console.WriteLine($"Az első két szám maradéka: {this.BekertErtek - szam.BekertErtek}.");
        }
        public void ElsoKertSzamSzorzata(Szam szam)
        {
            Console.WriteLine($"Az első két szám szorzata: {this.BekertErtek * szam.BekertErtek}.");
        }
        public void ElsoKertSzamOsztaleka(Szam szam)
        {
            if (BekertErtek >= 0 && this.BekertErtek >= 0)
            {
                Console.WriteLine($"Az első két szám osztaléka: {Math.Sqrt(this.BekertErtek / szam.BekertErtek)}.");
            }
            else
            {
                Console.WriteLine("A számhalmaz véges.");
            }
        }
        public void SzamokSzamtaniKozepe(Szam szam, Szam masikszam)
        {
            Console.WriteLine($"Az első két szám számtani közepe: {((double)this.BekertErtek + szam.BekertErtek + masikszam.BekertErtek) / 3:F3}.");
        }
        public void SzamokMertaniKozepe(Szam szam, Szam masikszam)
        {
            Console.WriteLine($"Az első két szám mértani közepe: {Math.Pow((this.BekertErtek * szam.BekertErtek * masikszam.BekertErtek), (double)1 / 3):F6}.");
        }
        public void SzamokMertaniKozepe2(Szam szam, Szam masikszam)
        {
            double mertank=Math.Exp(this.BekertErtek * szam.BekertErtek * masikszam.BekertErtek / 3);
            Console.WriteLine($"Az első két szám mértani közepe: {BekertErtek:F6}.");
        }
    }
 }
