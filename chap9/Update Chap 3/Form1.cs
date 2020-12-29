using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public void UpdateForm()
        {
            joeCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobCashLabel.Text = bob.Name + " has $" + bob.Cash;
            bankCashLabel.Text = "The bank has $" + bank;
        }
        public Form1()
        {
            InitializeComponent();
            joe = new Guy() { Cash = 50, Name = "Joe" };
            bob = new Guy() { Cash = 100, Name = "Bob" };
            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bob.Cash >= 5)
            {
                bank += bob.GiveCash(5);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bob is out of money.");
            }
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            if (joe.Cash >= 10)
            {
                joe.GiveCash(10);
                bob.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Joe is out of money.");
            }
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            if (bob.Cash >= 5)
            {
                bob.GiveCash(5);
                joe.ReceiveCash(5);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bob is out of money.");
            }
        }

        private void buttonSaveJoe_Click(object sender, EventArgs e)
        {
            using (Stream @out = File.Create("Guy_file.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(@out, joe);
            }
        }

        private void buttonLoadJoe_Click(object sender, EventArgs e)
        {
            using (Stream @in = File.OpenRead("Guy_file.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                joe = (Guy)formatter.Deserialize(@in);
            }
            UpdateForm();
        }
    }
}
