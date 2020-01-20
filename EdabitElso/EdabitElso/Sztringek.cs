using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitElso
{
    class Sztringek
    {
        public int ElsoSzam { get; set; }
        public string Szoveg { get; set; }
        public string Masodik { get; set; }
        public Sztringek(string szoveg)
        {
            this.Szoveg = szoveg;
        }
        public bool EgyenloHoszuakE(Sztringek masik)
        {
            if (this.Szoveg.Length == masik.Szoveg.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string osszefuz()
        {
            return this.Masodik + " ; " + this.Szoveg;
        }

        public bool van_eSpace()
        {
            if(this.Szoveg.Contains(" ") /*|| this.Masodik.Contains(" ")*/)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
