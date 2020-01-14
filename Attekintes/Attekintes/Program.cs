using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attekintes
{
    class Program
    {
        static void Main(string[] args)
        {
            Hazikedvenc hk = new Hazikedvenc();
            hk.Neme = "lány";
            Console.WriteLine($"A házikedvenc neme: {hk.Neme}");
            Hazikedvenc hk2 = new Hazikedvenc();
            hk2.Megvaltoztat("fiú");
            Console.WriteLine($"A házikedvenc neme: {hk2.Neme}");
            Console.ReadLine();
        }
    }
    class Hazikedvenc
    {
        //mező adattag
        private string neme;

        //mező property-je
        public string Neme {
            get { return this.neme; }
            set { this.neme = value; }
        }

        public void Megvaltoztat(string ertek)
        {
            this.neme = ertek;
            //Console.WriteLine($"A kedvenc neme: {this.neme}.");
        }
    }
}
