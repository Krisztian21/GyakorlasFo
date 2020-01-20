using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitElso
{
    class Elso
    {
        public int ElsoSzam { get; set; }
        public int MasodikSzam { get; set; }
        public bool LogikaiErtek { get; set; }

        public int PluszEgy { get; set; }

        public Elso(int a, int b)
        {
            this.ElsoSzam = a;
            this.MasodikSzam = b;
        }
        public int Sum(Elso ertek)
        {
            return this.ElsoSzam + ertek.ElsoSzam;
        }

        public int szampluszegy()
        {
            return this.PluszEgy + 1;
        }

        public int Maradek(Elso ertek)
        {
            return this.ElsoSzam % ertek.MasodikSzam;
        }
        public bool Elojel()
        {
            if (this.ElsoSzam <= 0)
            {
                return true;

            }
            else
            {
                return false;

            }
        }
        public Elso(int a)
        {
            this.ElsoSzam = a;
        }
        public Elso (bool b)
        {
            this.LogikaiErtek = b;
        }
        public bool Megfordit(bool LogikaiErtek)
        {
            return this.LogikaiErtek;
        }
        public bool Otteloszthato()
        {
            if(this.ElsoSzam%5==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Otteloszthato(Elso masik)
        {
            if (this.ElsoSzam % masik.ElsoSzam == 0)
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
