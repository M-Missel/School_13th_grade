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

        public void BTN_Action_Click(object sender, EventArgs e)
        {
            testOperation();
        }

        private void testOperation()
        {
            fillList();

            showList();

            Console.WriteLine("-----------------");

            list.RemoveAfter(15);

            showList();
        }

        private void fillList()
        {
            for (int i = 0; i < 10;i++)
            {
                list.AddLast(i);
            }
        }

        private void showList()
        {
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        private void showArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
