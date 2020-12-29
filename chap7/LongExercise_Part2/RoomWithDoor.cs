using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongExercise_Part2
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public string DoorDescription { get; private set; }

        public Location DoorLocation { get; set; }


        public RoomWithDoor(string name, string decoration, string hidingPlace ,string doorDescrption)
            :base(name, decoration, hidingPlace)
        {
            DoorDescription = doorDescrption;
        }

        public override string Description 
        {
            get
            {
                return base.Description + ", " + DoorDescription;
            }
        }
    }
}
