using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerketteteListe
{
    class Knoten<Typ>
    {
        private Knoten<Typ> naechster;
        private Typ inhalt;

        public Knoten(Typ pElement)
        {
            inhalt = pElement;
            naechster = null;
        }

        public void setzeNaechsten(Knoten<Typ> pKn)
        {
            this.naechster = pKn;
        }

        public Knoten<Typ> gibNaechsten()
        {
            return naechster;
        }

        public Typ gibInhalt()
        {
            return inhalt;
        }

        public void setzteInhalt(Typ pInhalt)
        {
            this.inhalt = pInhalt;
        }

        public override string ToString()
        {
            if (naechster != null)
            {
                return inhalt.ToString() + " -> " + naechster.ToString();
            }
            else
            {
                return inhalt.ToString();
            }
        }
    }
}
