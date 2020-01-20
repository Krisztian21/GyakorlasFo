using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitElso
{
    class Haromszog
    {
        public double ElsoSzam { get; set; }
        public double MasodikSzam { get; set; }

        public Haromszog(double a, double b)
        {
            this.ElsoSzam = a;
            this.MasodikSzam = b;
        }
        public double Terulet()
        {
            return (this.ElsoSzam * this.MasodikSzam) / 2;
        }
    }
}
