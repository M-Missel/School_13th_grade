using Linked_List.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linked_List
{
    public partial class Form1 : Form
    {
        private OwnList<int> list = new OwnList<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void fillList()
        {
            for (int i = 0; i < 10; i++)
            {
                list.AddLast(i);
            }
        }
    }
}
