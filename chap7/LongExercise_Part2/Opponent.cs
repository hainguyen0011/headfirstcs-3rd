using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongExercise_Part2
{
    class Opponent
    {
        private Location myLocation;
        private Random random;

        public Opponent(Location myLocation)
        {
            this.myLocation = myLocation;
            random = new Random();
        }
        public void Move()
        {
            bool hide = false;
            while (!hide)
            {
                if (myLocation is IHasExteriorDoor)
                {
                    if (random.Next(2) == 1)
                    {
                        IHasExteriorDoor temp = myLocation as IHasExteriorDoor;
                        myLocation = temp.DoorLocation;
                    }
                }
                int ranNum = random.Next(myLocation.Exits.Length);
                myLocation = myLocation.Exits[ranNum];
                if (myLocation is IHidingPlace)
                    hide = true;
            }
        }
        public bool Check(Location locationToCheck)
        {
            if (locationToCheck.Name.Equals(myLocation.Name))
                return true;
            else
                return false;
        }
    }
}
