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
        public GUI()
        {
            InitializeComponent();
        }

        public void B_erstelleZahlenbaum_Click(object sender, EventArgs e)
        {
            zahlenBaum = erstelleZahlenBaum();
            //MessageBox.Show(zahlenBaum.anzahlKnoten().ToString());
            zeichneBaum(zahlenBaum);
            MessageBox.Show(zahlenBaum.ausgebenDatenPostOrder());
        }

        public void B_erstelleTierbaum_Click(object sender, EventArgs e)
        {
            tierBaum = erstelleTierbaum();

            zeichneBaum(tierBaum);
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
