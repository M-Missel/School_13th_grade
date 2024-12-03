using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Binaerbaum<Typ>
    {
        private Knoten<Typ> wurzel;

        public Binaerbaum()
        {
            wurzel = null;
        }

        public Binaerbaum(Knoten<Typ> pWurzel)
        {
            this.wurzel = pWurzel;
        }

        public Knoten<Typ> gibWurzel()
        {
            return this.wurzel;
        }
        public void setzWurzel(Knoten<Typ> pWurzel)
        {
            this.wurzel = pWurzel;
        }

        public bool istLeer()
        {
            return wurzel == null;
        }

        public int anzahlKnoten()
        {
            return wurzel.anzahlKnoten();
        }

        public int anzahlBlaetter()
        {
            return wurzel.anzahlBlaetter();
        }

        public int tiefe()
        {
            return wurzel.tiefe();
        }

        public string ausgebenDateInOrder()
        {
            return $" [{wurzel.ausgebenDatenInOrder()}]";
        }

        public string ausgebenDatenPreOrder()
        {
            return $" [{wurzel.ausgebenDatenPreOrder()}]";
        }

        public string ausgebenDatenPostOrder()
        {
            return $" [{wurzel.ausgebenDatenPostOrder()}]";
        }

        public override string ToString()
        {
            return wurzel.ToString();
        }
    }
}
