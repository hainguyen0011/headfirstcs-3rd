using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Rowboat : Boat
    {
        public string rowTheBoat()
        {
            return "stroke natasha";
        }
    }
    class Boat
    {
        private int length;
        public void setLength(int len)
        {
            length = len;
        }
        public int getLength()
        {
            return length;
        }
        public virtual string move()
        {
            return " drift ";
        }
    }
    class TestBoats
    {
        public static void Main()
        {
            string xyz = "";
            Boat b1 = new Boat();
            Sailboat b2 = new Sailboat();
            Rowboat b3 = new Rowboat();
            b2.setLength(32);
            xyz = b1.move();
            xyz += b3.move();
            xyz += b2.move();
            System.Windows.Forms.MessageBox.Show(xyz);
        }
    }
    class Sailboat : Boat
    {
        public override string move()
        {
            return " hoist sail ";
        }
    }
}
