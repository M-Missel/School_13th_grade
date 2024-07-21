using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    public partial class Form1 : Form
    {
        Queue<int> queue = new Queue<int>();

        public Form1()
        {
            InitializeComponent();
        }

        public void BTN_Add_Item_Click(object sender, EventArgs e)
        {
            queue.enqueue(Convert.ToInt32(TB_Input.Text));

            printQueue();
        }

        public void BTN_Remove_Item_Click(object sender, EventArgs e)
        {
            queue.dequeue();

            printQueue();
        }

        private void printQueue()
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
