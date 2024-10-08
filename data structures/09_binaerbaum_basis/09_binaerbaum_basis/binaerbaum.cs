using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_binaerbaum_basis
{
    class binaerbaum<Typ>
    {
        private Knoten<Typ> wurzel;

        public binaerbaum()
        {
            wurzel = null;
        }

        public binaerbaum(Knoten<Typ> pWurzel)
        {
            this.wurzel = pWurzel;
        }

        public Knoten<Typ> gibWurzel()
        {
            return wurzel;
        }
        public void setzWurzel(Knoten<Typ> pWurzel)
        {
            this.wurzel = pWurzel;
        }

        public bool isLeer()
        {
            return wurzel == null;
        }
    }
}
