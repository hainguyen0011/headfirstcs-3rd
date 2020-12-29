using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_1
{
    public partial class Form1 : Form
    {
        Elephant lloyd;
        Elephant lucinda;
        public Form1()
        {
            InitializeComponent();
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 50 };
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 55 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lloyd.WhoAmI(), lloyd.Name + " says...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lucinda.WhoAmI(), lucinda.Name + " says...");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant temp = lucinda;
            lucinda = lloyd;
            lloyd = temp;
            MessageBox.Show("Object Swapped");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }
    }
}
