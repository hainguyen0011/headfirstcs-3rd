using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_Planner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numberDinner.Value, 
                fancyDinnerBox.Checked, healthyDinnerBox.Checked);
            birthdayParty = new BirthdayParty((int)numberBithday.Value,
                fancyBirthday.Checked, cakeWritingTxtBox.Text);
            DisplayDinnerPartyCost();
            DisplayBirthdayPartyCost();
        }

        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            birthdayCostLabel.Text = cost.ToString("c", 
                new System.Globalization.CultureInfo("vi-vn"));
        }
        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerParty.Cost;
            dinnerCostLabel.Text = cost.ToString("c", 
                new System.Globalization.CultureInfo("vi-vn"));
        }
        private void numberDinner_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numberDinner.Value;
            DisplayDinnerPartyCost();
        }

        private void fancyDinnerBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyDinnerBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void healthyDinnerBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyDinnerBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void numberBithday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBithday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = fancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWritingTxtBox_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWritingTxtBox.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
