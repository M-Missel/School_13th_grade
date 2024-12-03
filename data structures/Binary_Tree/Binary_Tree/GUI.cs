using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Tree
{
    public partial class GUI : Form
    {
        private Binaerbaum<int> zahlenBaum;
        private Binaerbaum<string> tierBaum;
        private List<int> ints;

        public GUI()
        {
            InitializeComponent();
            ints = new List<int>();
            zahlenBaum = new Binaerbaum<int>(new Knoten<int>(500));
        }

        public void B_erstelleZahlenbaum_Click(object sender, EventArgs e)
        {
            zahlenBaum = erstelleZahlenBaum(Convert.ToInt32(TB_Anzahl.Text));
            zeichneBaum(zahlenBaum);
        }

        public void B_erstelleTierbaum_Click(object sender, EventArgs e)
        {
            tierBaum = erstelleTierbaum();
            zeichneBaum(tierBaum);
        }

        public void BTN_inOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(zahlenBaum.ausgebenDateInOrder());
        }

        public void BTN_preOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(zahlenBaum.ausgebenDatenPreOrder());
        }

        public void BTN_postOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(zahlenBaum.ausgebenDatenPostOrder());
        }

        private Binaerbaum<int> erstelleZahlenBaum()
        {
            Binaerbaum<int> zahlenBaum = new Binaerbaum<int>(new Knoten<int>(7));

            zahlenBaum.gibWurzel().setzeRechtenKnoten(new Knoten<int>(12));
            // Linker Baum
            zahlenBaum.gibWurzel().setzeLinkenKnoten(new Knoten<int>(1));

            zahlenBaum.gibWurzel().gibLinkenKnoten().setzeLinkenKnoten(new Knoten<int>(0));
            zahlenBaum.gibWurzel().gibLinkenKnoten().setzeRechtenKnoten(new Knoten<int>(3));

            zahlenBaum.gibWurzel().gibLinkenKnoten().gibRechtenKnoten().setzeLinkenKnoten(new Knoten<int>(2));
            zahlenBaum.gibWurzel().gibLinkenKnoten().gibRechtenKnoten().setzeRechtenKnoten(new Knoten<int>(5));
            //Linker Baum

            //Rechter Baum

            zahlenBaum.gibWurzel().gibRechtenKnoten().setzeLinkenKnoten(new Knoten<int>(9));
            zahlenBaum.gibWurzel().gibRechtenKnoten().setzeRechtenKnoten(new Knoten<int>(13));

            zahlenBaum.gibWurzel().gibRechtenKnoten().gibLinkenKnoten().setzeLinkenKnoten(new Knoten<int>(8));
            zahlenBaum.gibWurzel().gibRechtenKnoten().gibLinkenKnoten().setzeRechtenKnoten(new Knoten<int>(10));
            zahlenBaum.gibWurzel().gibRechtenKnoten().gibRechtenKnoten().setzeRechtenKnoten(new Knoten<int>(15));

            //Rechter Baum

            return zahlenBaum;
        }

        private Binaerbaum<string> erstelleTierbaum()
        {
            Binaerbaum<string> tierBaum = new Binaerbaum<string>(new Knoten<string>("Säugetier"));

            tierBaum.gibWurzel().setzeLinkenKnoten(new Knoten<string>("Hund"));
            tierBaum.gibWurzel().setzeRechtenKnoten(new Knoten<string>("Affe"));

            tierBaum.gibWurzel().gibLinkenKnoten().setzeLinkenKnoten(new Knoten<string>("Collie"));
            tierBaum.gibWurzel().gibLinkenKnoten().setzeRechtenKnoten(new Knoten<string>("Dackel"));

            tierBaum.gibWurzel().gibRechtenKnoten().setzeLinkenKnoten(new Knoten<string>("Schmpanse"));
            tierBaum.gibWurzel().gibRechtenKnoten().setzeRechtenKnoten(new Knoten<string>("Orang-Utang"));

            return tierBaum;
        }

        /*
        private Binaerbaum<int> erstelleZahlenBaum(int pAnzahl)
        {
            Random random = new Random();
            int index;

            for (int i = 0; i < pAnzahl; i++)
            {
                index = random.Next(0, 1001);

                if (ints.Count == 0)
                {
                    ints.Add(index);
                }

                do
                {
                    index = random.Next(0,1001);
                } while (ints.Contains(index));

                fuegeEin(index);
                Console.Write(index + "\t");
            }

            Console.WriteLine("\n");

            return zahlenBaum;
        }
        */

        private Binaerbaum<int> erstelleZahlenBaum(int pAnzahl)
        {
            Random random = new Random();
            Knoten<int> knoten = zahlenBaum.gibWurzel();
            int index;


            for (int i = 0; i < pAnzahl; i++)
            {
                index = random.Next(0,101);

                while (knoten.gibInhalt().Equals(index))
                {
                    index = random.Next(0,101);
                    knoten = sucheImBaum(zahlenBaum.gibWurzel(), index);
                }

                fuegeEin(index);
            }

            return zahlenBaum;
        }

        private Knoten<int> sucheEinfuegeKnoten(Knoten<int> knoten, int newElem)
        {
            if (newElem <= knoten.gibInhalt())
            {
                if (knoten.gibLinkenKnoten() == null)
                {
                    return knoten;
                }
                else
                {
                    return sucheEinfuegeKnoten(knoten.gibLinkenKnoten(), newElem);
                }
            }
            else
            {
                if (knoten.gibRechtenKnoten() == null)
                {
                    return knoten;
                }
                else
                {
                    return sucheEinfuegeKnoten(knoten.gibRechtenKnoten(), newElem);
                }
            }
        }

        private Knoten<int> sucheImBaum(Knoten<int> knoten, int newElem)
        {
            if (knoten.gibInhalt().Equals(newElem))
            {
                return knoten;
            }

            if (newElem <= knoten.gibInhalt())
            {
                if (knoten.gibLinkenKnoten() == null)
                {
                    return knoten;
                }
                else
                {
                    return sucheImBaum(knoten.gibLinkenKnoten(), newElem);
                }
            }
            else
            {
                if (knoten.gibRechtenKnoten() == null)
                {
                    return knoten;
                }
                else
                {
                    return sucheImBaum(knoten.gibRechtenKnoten(), newElem);
                }
            }
        }

        private void fuegeEin(int newElem)
        {
            Knoten<int> newKnoten;
            if (zahlenBaum == null)
            {
                zahlenBaum = new Binaerbaum<int>(new Knoten<int>(newElem));
            }
            else
            {
                newKnoten = sucheEinfuegeKnoten(zahlenBaum.gibWurzel(), newElem);

                if (newElem <= newKnoten.gibInhalt())
                {
                    newKnoten.setzeLinkenKnoten(new Knoten<int>(newElem));
                }
                else
                {
                    newKnoten.setzeRechtenKnoten(new Knoten<int>(newElem));
                }
            }
        }

        private void zeichneBaum(Binaerbaum<int> baum)
        {
            GB_Output.Text = baum.ToString();
        }

        private void zeichneBaum(Binaerbaum<string> baum)
        {
            GB_Output.Text = baum.ToString();
        }
    }
}
