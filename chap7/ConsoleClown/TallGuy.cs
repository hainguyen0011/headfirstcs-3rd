using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClown
{
    class TallGuy : IClown
    {
        public string Name;
        public int Height;
        public string FunThingIhave { get { return " big shoes"; } }
        public int MyProperty { get;}

        public void Honk()
        {
            Console.WriteLine("Honk honk!");
        }

        public void Honk2()
        {
            Console.WriteLine("Honk2 honk2!");
        }

        public void TalkAboutYourSelf()
        {
            Console.WriteLine("My name is " + Name + " and I'm " + Height + " inches tall");
        }


    }
}
