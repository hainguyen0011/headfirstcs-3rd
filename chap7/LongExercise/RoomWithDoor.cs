using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongExercise
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        public string DoorDescription { get; private set; }

        public Location DoorLocation { get; set; }


        public RoomWithDoor(string name, string decoration, string doorDescrption):base(name, decoration)
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
