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
            personList.einfuegen(index, new Person(name));
        }

        public void printListe()
        {
            L_Ausgabe.Items.Clear();
            int anzahl = personList.anzahlElemente();

            for (int i = 0; i < anzahl; i++)
            {
                Person person = personList.inhalt(i);
                L_Ausgabe.Items.Add(person.getName());
            }

            L_Ausgabe.Items.Add("Ende");

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
            T_Ausgabe.Text = Convert.ToString(personList.inhalt(index));
        }

        private void B_ersetzen_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(T_Index.Text);
            string name = T_Name.Text;
            personList.ersetzen(index, new Person(name));
        }

        private void B_anhaengen_Click(object sender, EventArgs e)
        {
            string name = T_Name.Text;
            int index = Convert.ToInt32(T_Index.Text);
            personList.anhaegen(new Person(name));
        }

        private void T_entfernenClick(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(T_Index.Text);
            // todo
            T_Ausgabe.Text = Convert.ToString(personList.entfernen(index));
        }

        private void B_enthaelt_Click(object sender, EventArgs e)
        {
            string name = T_Name.Text;
            // todo
            T_Ausgabe.Text = personList.enthaelt(new Person(name)) ? "true" : "false";
        }

        private void T_entfElem_Click(object sender, EventArgs e)
        {
            string name = T_Name.Text;
            personList.entfernenElement(new Person(name));
        }
    }
}
