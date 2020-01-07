using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyokEgy
{
    class Fiu : Ember
    {
        private bool szemelyiszamEgyesE;
        public bool SzemelyiszamEgyesE
        {
            get { return szemelyiszamEgyesE; }
            set { this.szemelyiszamEgyesE=value; }
        }

        public Fiu(int magassag, int testsuly, string szuletesiEv, bool szem): base(magassag, testsuly, szuletesiEv)
        {
            this.SzemelyiszamEgyesE = szem;
        }
    }
}
