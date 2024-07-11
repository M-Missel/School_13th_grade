using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linked_List_School_Solution
{
    public partial class Form1 : Form
    {
        LinkedList<string> list = new LinkedList<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Einfuegen_Click(object sender, EventArgs e)
        {
            list.einfuegenVorne(TB_Name.Text);
        }

        private void BTN_Inhalt_Click(object sender, EventArgs e)
        {
            TB_Ausgabe.Text = list.inhalt(Convert.ToInt32(TB_Index.Text));
        }

        private void BTN_Entfernen_Click(object sender, EventArgs e)
        {
            list.entfernenVorne();
        }

        private void BTN_Ausgeben_Click(object sender, EventArgs e)
        {
            int anzahl = list.anzahlElemente();

            for (int i = 0; i < anzahl; i++)
            {
                LB_Output.Items.Add(list.inhalt(i));
            }
        }
    }
}
