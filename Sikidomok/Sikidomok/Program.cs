using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidomok
{
    class Program
    {

        static void Kiiras(Negyzet negy)
        {
            if(negy is Negyzet)
            {
                Console.WriteLine($"A négyzet kerülete: {negy.KeruletSzamol()}");
            }
            else if (negy is Teglalap)
            {
                Console.WriteLine($"A téglalap kerülete: {negy.KeruletSzamol()}");
            }
        }
        static void Main(string[] args)
        {
            /*Negyzet negyzet = new Negyzet(12);
            Console.WriteLine($"A négyzet területe: {negyzet.TeruletSzamol()}");
            Console.WriteLine($"A négyzet kerülete: {negyzet.KeruletSzamol()}");

            Teglalap teglalap = new Teglalap(12, 10);
            Console.WriteLine($"A téglalap területe: {teglalap.TeruletSzamol()}");
            Console.WriteLine($"A téglalap kerülete: {teglalap.KeruletSzamol*/

            //Negyzet negyzet = new Teglalap(12, 15);
            //Console.WriteLine($"A négyzet területe: {negyzet.TeruletSzamol()}");
            //Console.WriteLine($"A négyzet kerülete: {negyzet.KeruletSzamol()}");

            Negyzet negyzet = new Negyzet(10);
            Teglalap teglalap = new Teglalap(20, 30);
            Kiiras(negyzet);
            Kiiras(teglalap);
            /*Negyzet negy=new Negyzet();
            Negyzet teg= new Negyzet();*/

            /*negy.Kiir(negyzet);
            teg.Kiir(negyzet*/
            Console.ReadLine();

        }
    }
    class Negyzet
    {
        public int AOldal { get; set; }


        public Negyzet()
        {

        }

        public Negyzet(int aoldal)
        {
            this.AOldal = aoldal;
        }


        public int TeruletSzamol()
        {
            return this.AOldal * this.AOldal;
        }

        virtual public int KeruletSzamol()
        {
            return 4 * this.AOldal;
        }

        public void Kiir(Negyzet negy)
        {
            Console.WriteLine($"A négyzet kerülete: {negy.KeruletSzamol()}");
        }
    }
    class Teglalap : Negyzet
    {
        public int Boldal { get; set; }

        public Teglalap()
        {

        }

        public Teglalap(int aOldal, int bOldal) : base(aOldal)
        {
            this.Boldal = bOldal;
        }

        new public int TeruletSzamol()
        {
            return this.AOldal * this.Boldal;

        }

        override public int KeruletSzamol()
        {
            return 2 * (this.AOldal + Boldal);

        }

        new public void Kiir(Negyzet teg)
        {
            Console.WriteLine($"A téglalap kerülete: {teg.KeruletSzamol()}");
        }
    }
}

