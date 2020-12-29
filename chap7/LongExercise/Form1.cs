using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LongExercise
{
    public partial class Form1 : Form
    {
        Outside garden;
        OutsideWithDoor frontYard, backYard;
        Room diningRoom;
        RoomWithDoor livingRoom, kitchen;

        Location currentLocation;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(frontYard);
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor temp = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(temp.DoorLocation);
        }

        public void CreateObjects()
        {
            garden = new Outside("Garden", false);
            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            diningRoom = new Room("Dining Room", "a crystal chandelier");
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "a screen door that leads to the back yard");

            garden.Exits = new Location[] { frontYard, backYard };
            frontYard.Exits = new Location[] { livingRoom, garden };
            backYard.Exits = new Location[] { kitchen, garden };
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom, frontYard };
            kitchen.Exits = new Location[] { diningRoom, backYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        public void MoveToANewLocation(Location currentLocation)
        {
            this.currentLocation = currentLocation;
            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                exits.Items.Add(currentLocation.Exits[i].Name);
            }
            exits.SelectedIndex = 0;
            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
            richTextBox1.Text = currentLocation.Description;
        }
    }
}
