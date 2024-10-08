using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_binaerbaum_basis
{
    public partial class GUI : Form
    {
        private binaerbaum<int> zahlenBaum;
        private binaerbaum<string> tierBaum;
        public GUI()
        {
            InitializeComponent();
        }

        public void B_erstelleZahlenbaum_Click(object sender, EventArgs e)
        {
            zahlenBaum = erstelleZahlenBaum();
        }

        public void B_erstelleTierbaum_Click(object sender, EventArgs e)
        {
            tierBaum = erstelleTierbaum();
        }

        private binaerbaum<int> erstelleZahlenBaum()
        {
            binaerbaum<int> zahlenBaum = new binaerbaum<int>(new Knoten<int>(5));

            zahlenBaum.gibWurzel().setzeLinkenKnoten(new Knoten<int>(2));
            zahlenBaum.gibWurzel().setzeRechtenKnoten(new Knoten<int>(7));

            zahlenBaum.gibWurzel().gibRechtenKnoten().setzeLinkenKnoten(new Knoten<int>(6));

            return zahlenBaum;
        }

        private binaerbaum<string> erstelleTierbaum()
        {
            binaerbaum<string> tierBaum = new binaerbaum<string>(new Knoten<string>("Säugetier"));

            tierBaum.gibWurzel().setzeLinkenKnoten(new Knoten<string>("Hund"));
            tierBaum.gibWurzel().setzeRechtenKnoten(new Knoten<string>("Affe"));

            tierBaum.gibWurzel().gibLinkenKnoten().setzeLinkenKnoten(new Knoten<string>("Collie"));
            tierBaum.gibWurzel().gibLinkenKnoten().setzeRechtenKnoten(new Knoten<string>("Dackel"));

            tierBaum.gibWurzel().gibRechtenKnoten().setzeLinkenKnoten(new Knoten<string>("Schmpanse"));
            tierBaum.gibWurzel().gibRechtenKnoten().setzeRechtenKnoten(new Knoten<string>("Orang-Utang"));

            return tierBaum;
        }
    }
}
