using System.IO.Ports;

namespace SloppyJoe
{
    public class MenuItem
    {
        public string Meat { get; set; }
        public string Condiment { get; set; }
        public string Bread { get; set; }

        public MenuItem(string randomMeat, string randomCondiment, string randomBread)
        {
            Meat = randomMeat;
            Condiment = randomCondiment;
            Bread = randomBread;
        }
        public override string ToString()
        {
            return Meat + " with " + Condiment + " on " + Bread;
        }
    }
}