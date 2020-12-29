using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LongExercise_Part2
{
    public partial class Form1 : Form
    {
        OutsideWithDoor frontYard, backYard;
        Room diningRoom, stairs;
        RoomWithDoor livingRoom, kitchen;
        RoomWithHidingPlace upstairsHallway, masterBedroom, secondBedroom, bathroom;
        OutsideWithHidingPlace driveway, garden;
        Opponent opponent;
        int Moves;
        bool status = true;

        Location currentLocation;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            RedrawForm();
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


        private void check_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
            {
                ResetGame(true);
                RedrawForm();
            }
            else
                MessageBox.Show("She's not here");
        }

        private void hide_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                opponent.Move();
                description.Text += i + 1 + "\n";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            description.Text += "\n\nReady or not, here I come!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            MoveToANewLocation(livingRoom);
            RedrawForm();
        }

        public void CreateObjects()
        {
            diningRoom = new Room("Dining Room", "a crystal chandelier");
            stairs = new Room("Stairs", "a wooden bannister");

            garden = new OutsideWithHidingPlace("Garden", false, "the shed");
            driveway = new OutsideWithHidingPlace("Driveway", false, "the garage");

            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");

            upstairsHallway = new RoomWithHidingPlace("Upstairs Hallway", "a picture of a dog", "in the closet");
            masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a large bed", "under the bed");
            secondBedroom = new RoomWithHidingPlace("Second Bedroom", "a small bed", "under the bed");
            bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a toilet", "in the shower");

            livingRoom = new RoomWithDoor("Living Room", "an antique carpet",
                "in the closet", "an oak door with a brass knob");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances",
                "the cabinet", "a screen door that leads to the back yard");


            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            stairs.Exits = new Location[] { livingRoom, upstairsHallway };

            garden.Exits = new Location[] { frontYard, backYard };
            driveway.Exits = new Location[] { frontYard, backYard };

            frontYard.Exits = new Location[] { livingRoom, garden, driveway };
            backYard.Exits = new Location[] { kitchen, garden, driveway };

            upstairsHallway.Exits = new Location[] { stairs, masterBedroom, secondBedroom, bathroom };
            masterBedroom.Exits = new Location[] { upstairsHallway };
            secondBedroom.Exits = new Location[] { upstairsHallway };
            bathroom.Exits = new Location[] { upstairsHallway };

            livingRoom.Exits = new Location[] { diningRoom, frontYard ,stairs};
            kitchen.Exits = new Location[] { diningRoom, backYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

            opponent = new Opponent(frontYard);
        }

        public void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;
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
            if (currentLocation is IHidingPlace)
            {
                check.Visible = true;
                IHidingPlace temp = currentLocation as IHidingPlace;
                check.Text = "Check" + temp.HidingPlace;
            }
            else
                check.Visible = false;
            description.Text = currentLocation.Description;
        }
        public void RedrawForm()
        {
            if (status)
            {
                hide.Visible = true;
                goHere.Visible = false;
                check.Visible = false;
                goThroughTheDoor.Visible = false;
                exits.Visible = false;
                status = false;
            }
            else
            {
                hide.Visible = false;
                goHere.Visible = true;
                check.Visible = true;
                goThroughTheDoor.Visible = true;
                exits.Visible = true;
                status = true;
            }
        }
        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("You found me in " + Moves + " moves!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                description.Text = "You found your opponent in " + Moves
                + " moves! He was hiding " + foundLocation.HidingPlace + ".";
            }
            opponent = new Opponent(frontYard);
            Moves = 0;
        }
    }
}
