using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace VerketteteListe
{
    public partial class GUI : Form
    {
        VerketteteListen<Person> personList;

        public GUI()
        {
            InitializeComponent();
            personList = new VerketteteListen<Person>();
        }

        private void B_insert_Click(object sender, EventArgs e)
        {
            string name = T_Name.Text;
            int index = Convert.ToInt32(T_Index.Text);

        }

        public void printListe()
        {
            // todo 

            showListAsGraph();
        }

        private void showListAsGraph()
        {
            G_Liste.Text = personList.ToString();
        }

        private void B_ausgeben_Click(object sender, EventArgs e)
        {
            printListe();
        }

        private void B_inhalt_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(T_Index.Text);
            // todo
            // todo: T_Ausgabe.Text = ...
        }

        private void B_ersetzen_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(T_Index.Text);
            string name = T_Name.Text;
            // todo
        }

        private void B_anhaengen_Click(object sender, EventArgs e)
        {
            string name = T_Name.Text;
            int index = Convert.ToInt32(T_Index.Text);
            // todo
        }

        private void T_entfernenClick(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(T_Index.Text);
            // todo
            // todo T_Ausgabe.Text = ...
        }

        private void B_enthaelt_Click(object sender, EventArgs e)
        {
            string name = T_Name.Text;
            // todo
            // todo T_Ausgabe.Text = ...
        }

        private void T_entfElem_Click(object sender, EventArgs e)
        {
            string name = T_Name.Text;
            personList.entfernenElement();
        }
    }
}
