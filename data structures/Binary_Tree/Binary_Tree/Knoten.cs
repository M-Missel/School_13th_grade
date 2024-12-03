using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
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

        public int anzahlKnoten()
        {
            int anzL = 0, anzR = 0;

            if (linkerKnoten != null)
                anzL = linkerKnoten.anzahlKnoten();

            if (rechterKnoten != null)
                anzR = rechterKnoten.anzahlKnoten();

            return 1 + anzL + anzR;
        }

        public int anzahlBlaetter()
        {
            int anzahl = 0;
            if (linkerKnoten == null && rechterKnoten == null)
            {
                anzahl++;
            }

            if (linkerKnoten != null)
            {
                anzahl += linkerKnoten.anzahlBlaetter();
            }

            if (rechterKnoten != null)
            {
                anzahl += rechterKnoten.anzahlBlaetter();
            }

            return anzahl;
        }

        public int tiefe()
        {
            int anzL = 0, anzR = 0;

            if (linkerKnoten != null)
            {
                anzL = linkerKnoten.tiefe() + 1;
            }

            if (rechterKnoten != null)
            {
                anzR = rechterKnoten.tiefe() + 1;
            }

            if (anzL < anzR)
            {
                return anzR;
            }
            else
            {
                return anzL;
            }
        }

        public string ausgebenDatenInOrder()
        {
            string str = "";
            if (linkerKnoten != null)
            {
                str += $"{linkerKnoten.ausgebenDatenInOrder()}";
            }

            str += $" {gibInhalt()}";

            if (rechterKnoten != null)
            {
                str += $"{rechterKnoten.ausgebenDatenInOrder()}";
            }

            return str;
        }

        public string ausgebenDatenPreOrder()
        {
            string str = "";

            str += $" {gibInhalt()}";

            if (linkerKnoten != null)
            {
                str += $"{linkerKnoten.ausgebenDatenPreOrder()}";
            }

            if (rechterKnoten != null)
            {
                str += $"{rechterKnoten.ausgebenDatenPreOrder()}";
            }

            return str;
        }

        public string ausgebenDatenPostOrder()
        {
            string str = "";

            if (linkerKnoten != null)
            {
                str += $"{linkerKnoten.ausgebenDatenPostOrder()}";
            }

            if (rechterKnoten != null)
            {
                str += $"{rechterKnoten.ausgebenDatenPostOrder()}";
            }

            str += $" {gibInhalt()}";

            return str;
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
                knotenstr += $"\"{inhalt.ToString()}\" ->  \"{rechterKnoten.gibInhalt().ToString()}\"; ";
                knotenstr += rechterKnoten.ToString();
            }

            Console.WriteLine(knotenstr);

            return knotenstr;
        }
    }
}
