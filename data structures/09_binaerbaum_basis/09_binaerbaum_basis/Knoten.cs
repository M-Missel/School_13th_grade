using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_binaerbaum_basis
{
    class Knoten<Typ>
    {
        private Typ inhalt;
        private Knoten<Typ> linkerKnoten;
        private Knoten<Typ> rechterKnoten;

        public Knoten(Typ pInhalt)
        {
            this.inhalt = pInhalt;
        }

        public Typ gibInhalt()
        {
            return inhalt;
        }

        public void setzeInhalt(Typ pInhalt)
        {
            this.inhalt = pInhalt;
        }

        public Knoten<Typ> gibLinkenKnoten()
        {
            return linkerKnoten;
        }

        public Knoten<Typ> gibRechtenKnoten()
        {
            return rechterKnoten;
        }

        public void setzeLinkenKnoten(Knoten<Typ> pLinks)
        {
            this.linkerKnoten = pLinks;
        }

        public void setzeRechtenKnoten(Knoten<Typ> pRechts)
        {
            this.rechterKnoten = pRechts;
        }

        public bool istbBlatt()
        {
            return (rechterKnoten == null && linkerKnoten == null);
        }

        public override string ToString()
        {
            string knotenstr = "";

            if (linkerKnoten != null)
            {
                knotenstr = $"\"{inhalt.ToString()}\" ->  \"{linkerKnoten.gibInhalt().ToString()}\"; ";
                knotenstr += linkerKnoten.ToString();
            }
            if (rechterKnoten != null)
            {
                knotenstr = $"\"{inhalt.ToString()}\" ->  \"{rechterKnoten.gibInhalt().ToString()}\"; ";
                knotenstr += rechterKnoten.ToString();
            }

            return knotenstr;
        }
    }
}
