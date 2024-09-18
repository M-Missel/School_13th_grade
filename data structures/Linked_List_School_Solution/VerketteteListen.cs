using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerketteteListe
{
    class VerketteteListen<Typ>
    {
        private Knoten<Typ> erster;

        public VerketteteListen()
        {
            erster = null;
        }

        public int anzahlElemente()
        {
            int anzahl = 0;
            Knoten<Typ> knoten = erster;
            while (knoten != null)
            {
                knoten = knoten.gibNaechsten();
                anzahl++;
            }

            return anzahl;
        }

        public Typ inhalt(int pIndex)
        {
            if (pIndex >= 0 && pIndex < anzahlElemente())
            {
                Knoten<Typ> knoten = erster;

                for (int i = 0; i < pIndex; i++)
                {
                    knoten = knoten.gibNaechsten();
                }

                return knoten.gibInhalt();
            }
            else
            {
                return default;
            }
        }

        public void einfuegenVorne(Typ pInhalt)
        {
            Knoten<Typ> neu = new Knoten<Typ>(pInhalt);
            neu.setzeNaechsten(erster);
            erster = neu;
        }

        public Typ entferneVorne()
        {
            Typ inhalt;

            if (erster != null)
            {
                inhalt = erster.gibInhalt();
                erster = erster.gibNaechsten();
            }
            else
            {
                inhalt = default;
            }

            return inhalt;
        }

        public bool istLeer()
        {
            return erster == null;
        }

        public void ersetzen(int pIndex, Typ pInhalt)
        {
            Knoten<Typ> k;

            if (pIndex >= 0 && pIndex < anzahlElemente())
            {
                k = erster;

                for (int i = 0; i < pIndex; i++)
                {
                    k = k.gibNaechsten();
                }

                k.setzteInhalt(pInhalt);
            }
        }

        public void einfuegen(int pIndex, Typ pInhalt)
        {
            int anzahl = anzahlElemente();

            if (anzahl > pIndex && pIndex >= 0)
            {
                Knoten<Typ> knoten = erster;
                Knoten<Typ> neu = new Knoten<Typ>(pInhalt);

                for (int i = 0; i < pIndex; i++)
                {
                    knoten = knoten.gibNaechsten();
                }

                Knoten<Typ> knext = knoten.gibNaechsten();
                knoten.setzeNaechsten(neu);
                neu.setzeNaechsten(knext);
            }
        }

        public void anhaegen(Typ pInhalt)
        {
            if (erster != null)
            {
                Knoten<Typ> knoten = erster;

                while (knoten.gibNaechsten() != null)
                {
                    knoten = knoten.gibNaechsten();
                }

                knoten.setzeNaechsten(new Knoten<Typ>(pInhalt));
            }
            else
            {
                erster = new Knoten<Typ>(pInhalt);
            }
        }

        public Typ entfernen(int pIndex)
        {
            Knoten<Typ> knoten = erster;
            Typ del = default;

            if (pIndex >= 0 && pIndex < anzahlElemente())
            {
                if (pIndex == 0)
                {
                    del = erster.gibInhalt();
                    erster = erster.gibNaechsten();
                }
                else
                {
                    for (int i = 0; i < pIndex - 2; i++)
                    {
                        knoten = knoten.gibNaechsten();
                    }

                    del = knoten.gibNaechsten().gibInhalt();
                    knoten.setzeNaechsten(knoten.gibNaechsten().gibNaechsten());
                }
            }

            return del;
        }

        public void entfernenElement(Typ pInhalt)
        {
            if (istLeer())
            {
                throw new IndexOutOfRangeException();
            }

            Knoten<Typ> temp = erster;
            bool gefunden = false;
            int Index = 0;
            int anzahlElement = anzahlElemente();

            while (gefunden == false)
            {
                if (Index < anzahlElement)
                {
                    if (temp.gibInhalt().Equals(pInhalt))
                    {
                        entfernen(Index);
                        gefunden = true;
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }

                Index++;
                temp = temp.gibNaechsten();
            }
        }

        public bool enthaelt(Typ pInhalt)
        {
            Knoten<Typ> knoten = erster;

            while (knoten.gibNaechsten() != null)
            {
                if (knoten.gibInhalt().Equals(pInhalt))
                {
                    return true;
                }

                knoten = knoten.gibNaechsten();
            }

            return false;
        }

        public override string ToString()
        {
            string ersterString = "";
            for (int i = 0; i < anzahlElemente()-1; i++)
            {
                string source = inhalt(i).ToString();
                string dest = inhalt(i + 1).ToString();
                ersterString += source + " -> " + dest + ";";
            }

            return ersterString;
        }
    }
}
