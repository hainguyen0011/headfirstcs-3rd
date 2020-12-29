using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    class Greyhound
    {
        public int StartingLocation;
        public int RacetrackLength;
        public PictureBox MyPictureBox;
        public int Location = 0;
        public Random Randomizer;

        public bool Run()
        {
            Location = MyPictureBox.Left;
            Location += Randomizer.Next(1, 4);
            MyPictureBox.Left = Location;
            if (Location >= RacetrackLength)
                return true;
            return false;
        }
        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingLocation;
        }
    }


}
