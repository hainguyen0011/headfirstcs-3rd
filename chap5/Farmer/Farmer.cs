using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer
{
    class Farmer
    {
        
        public int BagsOfFeed { get; set; }
        private int numberOfCows;
        private int feedMultiplier;

        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;

        }
        public int FeedMultiplier { get { return feedMultiplier; } }
        public int NumberOfCows
        {
            get { return numberOfCows; }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
    }
}
