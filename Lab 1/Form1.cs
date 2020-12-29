using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Guy[] guy = new Guy[3];
        Greyhound[] dog = new Greyhound[4];

        public Form1()
        {
            InitializeComponent();
            minimumBetLabel.Text =
                "Minimum bet: " + buckUpDown.Minimum + " bucks";
            InitDog();
            InitGuy();
            UpdateLabel();
        }
        public void InitGuy()
        {
            guy[0] = new Guy()
            {
                Name = "Joe",
                Cash = 100,
                MyLabel = joeBetLabel,
                MyRadioButton = joeRadioButton,
                MyBet = new Bet()
            };

            guy[1] = new Guy()
            {
                Name = "Bob",
                Cash = 100,
                MyLabel = bobBetLabel,
                MyRadioButton = bobRadioButton,
                MyBet = new Bet()
            };

            guy[2] = new Guy()
            {
                Name = "Al",
                Cash = 100,
                MyLabel = alBetLabel,
                MyRadioButton = alRadioButton,
                MyBet = new Bet()
            };
            for (int i = 0; i < guy.Length; i++)
            {
                guy[i].MyBet.Bettor = guy[i];
            }
        }

        public void InitDog()
        {
            dog[0] = new Greyhound()
            {
                Randomizer = random,
                StartingLocation = dog1_pictureBox.Left,
                MyPictureBox = dog1_pictureBox,
                RacetrackLength = raceTrackPictureBox.Width - dog1_pictureBox.Width,
            };

            dog[1] = new Greyhound()
            {
                Randomizer = random,
                StartingLocation = dog2_pictureBox.Left,
                MyPictureBox = dog2_pictureBox,
                RacetrackLength = raceTrackPictureBox.Width - dog2_pictureBox.Width,
            };

            dog[2] = new Greyhound()
            {
                Randomizer = random,
                StartingLocation = dog3_pictureBox.Left,
                MyPictureBox = dog3_pictureBox,
                RacetrackLength = raceTrackPictureBox.Width - dog3_pictureBox.Width,
            };

            dog[3] = new Greyhound()
            {
                Randomizer = random,
                StartingLocation = dog4_pictureBox.Left,
                MyPictureBox = dog4_pictureBox,
                RacetrackLength = raceTrackPictureBox.Width - dog4_pictureBox.Width,
            };
        }

        public void Reset()
        {
            for (int i = 0; i < guy.Length; i++)
            {
                guy[i].ClearBet();
            }
            for (int i = 0; i < dog.Length; i++)
            {
                dog[i].TakeStartingPosition();
            }
        }

        public void UpdateLabel()
        {
            for (int i = 0; i < guy.Length; i++)
            {
                guy[i].UpdateLabels();
            }
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if (joeRadioButton.Checked)
            {
                if (!guy[0].PlaceBet((int)buckUpDown.Value,
                    (int)indexUpDown.Value))
                {
                    MessageBox.Show(guy[0].Name +
                        " doesn't have enough cash!", "Warning!!!");
                }
            }
            else if (bobRadioButton.Checked)
            {
                if (!guy[1].PlaceBet((int)buckUpDown.Value,
                    (int)indexUpDown.Value))
                {
                    MessageBox.Show(guy[1].Name +
                        " doesn't have enough cash!", "Warning!!!");
                }
            }
            else
            {
                if (!guy[2].PlaceBet((int)buckUpDown.Value,
                    (int)indexUpDown.Value))
                {
                    MessageBox.Show(guy[2].Name +
                        " doesn't have enough cash!", "Warning!!!");
                }
            }
            UpdateLabel();
        }
        private void raceButton_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            timer1.Start();
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Joe";
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Bob";
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Al";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dog.Length; i++)
            {
                if (dog[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show("Dog #" + (i + 1) + " won the race!",
                        "We have a winner!!!");
                    for (int j = 0; j < guy.Length; j++)
                    {
                        guy[j].Collect(i + 1);
                    }
                    Reset();
                    UpdateLabel();
                    groupBox1.Enabled = true;
                }
            }
        }
    }
}
