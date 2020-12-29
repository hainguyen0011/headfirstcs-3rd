using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LumberjackEating
{
    public partial class Form1 : Form
    {
        private Queue<Lumberjack> breakfastLine;
        public Form1()
        {
            InitializeComponent();
            breakfastLine = new Queue<Lumberjack>();
            RedrawList();
        }

        public void RedrawList()
        {
            line.Items.Clear();
            if (breakfastLine.Count > 0)
            {
                foreach (Lumberjack item in breakfastLine)
                {
                    line.Items.Add(item.Name);
                }
                Lumberjack current = breakfastLine.Peek();
                nameFlapjack.Text = current.Name + "'s eating " + current.FlapjackCount + " flapjacks";
            }
            else
                nameFlapjack.Text = "";
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            Flapjack food;
            if (crispy.Checked == true)
                food = Flapjack.Crispy;
            else if (soggy.Checked == true)
                food = Flapjack.Soggy;
            else if (browned.Checked == true)
                food = Flapjack.Browned;
            else
                food = Flapjack.Banana;
            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food,
            (int)howMany.Value);
            RedrawList();
        }

        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count > 0)
            {
                Lumberjack current = breakfastLine.Peek();
                if (current.FlapjackCount > 0)
                {
                    current.EatFlapjacks();
                    breakfastLine.Dequeue();
                    RedrawList();
                }
                else
                    MessageBox.Show(current.Name + "did not eat anything");
            }
        }

        private void addLumberjack_Click(object sender, EventArgs e)
        {
            if (name.Text != "")
            {
                Lumberjack newGuy = new Lumberjack(name.Text);
                breakfastLine.Enqueue(newGuy);
                RedrawList();
            }
        }
    }
}
