using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Form1 : Form
    {
        private Random random;
        Stats stats;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            stats = new Stats();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game Over");
                restartButton.Visible = true;
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;
                difficultyProgressBar.Value = 800 - timer1.Interval;

                stats.Update(true);
            }
            else
            {
                stats.Update(false);
            }
            // Update the labels on the StatusStrip
            UpdateValue();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            stats = new Stats();
            stats.Reset();
            UpdateValue();
            listBox1.Items.Clear();
            timer1.Interval = 800;
            difficultyProgressBar.Value = 0;
            timer1.Start();
            restartButton.Visible = false;
        }

        public void UpdateValue()
        {
            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = "Missed: " + stats.Missed;
            totalLabel.Text = "Total: " + stats.Total;
            accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
        }
    }
}
